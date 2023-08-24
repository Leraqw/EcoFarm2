using System.Collections.Generic;
using Entitas;
using UnityEngine;
using Zenject;
using static PlayerMatcher;

namespace EcoFarm
{
	public class ChooseCurrentPlayerSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly IDataProviderService _dataProvider;

		[Inject]
		public ChooseCurrentPlayerSystem(Contexts contexts, IDataProviderService dataProvider) :
			base(contexts.player)
			=> _dataProvider = dataProvider;

		private PlayerView PlayerViewPrefab => _dataProvider.PlayerView;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(AllOf(CurrentPlayer));

		protected override bool Filter(PlayerEntity entity) => entity.isCurrentPlayer;

		protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ChangeCurrentPlayer);

		private void ChangeCurrentPlayer(PlayerEntity player)
		{
			player.ReplaceNickname(PlayerViewPrefab.Player.Nickname);
			player.ReplaceCompletedLevelsCount(PlayerViewPrefab.Player.CompletedLevelsCount);

			Debug.Log(player.nickname.Value);
		}
	}
}
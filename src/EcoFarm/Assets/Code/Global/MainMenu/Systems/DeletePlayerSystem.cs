using System.Collections.Generic;
using Entitas;
using Entitas.VisualDebugging.Unity;
using Zenject;
using static PlayerMatcher;

namespace EcoFarm
{
	public class DeletePlayerSystem : ReactiveSystem<PlayerEntity>
	{
		private readonly IDataProviderService _dataProvider;

		[Inject]
		public DeletePlayerSystem(Contexts contexts, IDataProviderService dataProvider)
			: base(contexts.player)
			=> _dataProvider = dataProvider;

		private PlayersList PlayersList => _dataProvider.PlayersList;

		protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
			=> context.CreateCollector(AllOf(PlayerToEdit, ToDelete));

		protected override bool Filter(PlayerEntity entity) => entity.hasPlayerToEdit && entity.isToDelete;

		protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(Delete);

		private void Delete(PlayerEntity entity)
		{
			var playerView = entity.playerToEdit.Value;

			PlayersList.RemovePlayer(playerView.Player);

			playerView.gameObject.DestroyGameObject();
			entity.isToDelete = false;
		}
	}
}
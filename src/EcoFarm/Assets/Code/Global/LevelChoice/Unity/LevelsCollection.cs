using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class LevelsCollection : StartEntityBehaviour
	{
		[SerializeField] private UnlockedLevelsCountView _view;

		private PlayerEntity.Factory _playerEntityFactory;

		[Inject]
		public void Construct(PlayerEntity.Factory gameEntityFactory)
			=> _playerEntityFactory = gameEntityFactory;

		private static PlayerEntity CurrentPlayer => Contexts.player.currentPlayerEntity;

		protected override void Initialize()
		{
			var e = _playerEntityFactory.Create();
			e.isLevelRelatedEntity = true;
			e.AddUnlockedLevelsCount(CurrentPlayer.completedLevelsCount.Value);
			_view.Register(e);
			e.AddView(gameObject);
		}
	}
}
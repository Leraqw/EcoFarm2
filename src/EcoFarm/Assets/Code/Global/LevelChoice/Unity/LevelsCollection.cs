using UnityEngine;

namespace EcoFarm
{
	public class LevelsCollection : StartEntityBehaviour
	{
		[SerializeField] private UnlockedLevelsCountView _view;

		private static PlayerEntity CurrentPlayer => Contexts.player.currentPlayerEntity;

		protected override void Initialize()
		{
			var e = Contexts.player.CreateEntity();
			e.isLevelRelatedEntity = true;
			e.AddUnlockedLevelsCount(CurrentPlayer.completedLevelsCount.Value);
			_view.Register(e);
			e.AddView(gameObject);
		}
	}
}
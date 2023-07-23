
using UnityEngine;

namespace Code
{
	public class LevelsCollection : EntityBehaviour
	{
		[SerializeField] private UnlockedLevelsCountView _view;

		private PlayerEntity CurrentPlayer => Contexts.player.currentPlayerEntity;

		protected override bool ReadyForInitialization() => true;

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
using Code.EntityBehaviours;
using UnityEngine;

namespace Code.Global.LevelChoice.Unity
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
			e.AddUnlockedLevelsCount(CurrentPlayer.GetCompletedUnlockedLevelsCount());
			_view.Register(e);
			e.AddView(gameObject);
		}
	}
}
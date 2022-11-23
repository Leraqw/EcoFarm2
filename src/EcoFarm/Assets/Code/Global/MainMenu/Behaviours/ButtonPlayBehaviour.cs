using Code.EntityBehaviours;
using Code.Global.MainMenu.Views;
using UnityEngine;

namespace Code.Global.MainMenu.Behaviours
{
	public class ButtonPlayBehaviour : EntityBehaviour
	{
		[SerializeField] private ActiveView _activeView;

		protected override bool ReadyForInitialization() => true;

		protected override void Initialize()
		{
			var e = Contexts.player.CreateEntity();
			e.AddView(gameObject);
			e.AddActive(true);
			_activeView.Register(e);
		}
	}
}
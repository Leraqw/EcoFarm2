using Code.EntityBehaviours;
using Code.Global.MainMenu.Views;
using UnityEngine;

namespace Code.Global.MainMenu.Behaviours
{
	public class ButtonPlayBehaviour : EntityBehaviour
	{
		[SerializeField] private InteractableView _interactableView;

		protected override bool ReadyForInitialization() => true;

		protected override void Initialize()
		{
			var e = Contexts.player.CreateEntity();
			e.AddView(gameObject);
			e.AddInteractable(true);
			e.isForPlayerButton = true;
			_interactableView.Register(e);
		}
	}
}
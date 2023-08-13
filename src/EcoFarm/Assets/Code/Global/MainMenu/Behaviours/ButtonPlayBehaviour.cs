using UnityEngine;

namespace EcoFarm
{
	public class ButtonPlayBehaviour : StartEntityBehaviour
	{
		[SerializeField] private InteractableView _interactableView;

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
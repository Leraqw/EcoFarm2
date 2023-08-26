using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public class ButtonPlayBehaviour : StartEntityBehaviour
	{
		[SerializeField] private InteractableView _interactableView;

		private PlayerEntity.Factory _playerEntityFactory;

		[Inject]
		public void Construct(PlayerEntity.Factory playerEntityFactory)
			=> _playerEntityFactory = playerEntityFactory;

		protected override void Initialize()
		{
			var e = _playerEntityFactory.Create();
			e.AddView(gameObject);
			e.AddInteractable(false);
			_interactableView.Register(e);
			e.isForPlayerButton = true;
		}
	}
}
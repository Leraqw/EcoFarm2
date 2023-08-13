using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
	public class InteractableView : MonoBehaviour, IInteractableListener
	{
		[SerializeField] private Button _button;

		private PlayerEntity _entity;

		public void OnInteractable(PlayerEntity entity, bool value) => _button.interactable = value;

		public void Register(PlayerEntity entity)
		{
			_entity = entity;
			_entity.AddInteractableListener(this);

			if (_entity.hasInteractable)
			{
				OnInteractable(_entity, _entity.interactable.Value);
			}
		}
	}
}
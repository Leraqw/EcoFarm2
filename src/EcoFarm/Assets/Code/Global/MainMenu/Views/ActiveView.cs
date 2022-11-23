using UnityEngine;

namespace Code.Global.MainMenu.Views
{
	public class ActiveView : MonoBehaviour, IActiveListener
	{
		private PlayerEntity _entity;

		public void OnActive(PlayerEntity entity, bool value) => gameObject.SetActive(value);

		public void Register(PlayerEntity entity)
		{
			_entity = entity;
			_entity.AddActiveListener(this);

			if (_entity.hasActive)
			{
				OnActive(_entity, _entity.active.Value);
			}
		}
	}
}
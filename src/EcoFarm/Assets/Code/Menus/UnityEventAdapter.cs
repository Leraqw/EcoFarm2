using UnityEngine;
using UnityEngine.UI;

namespace Code.Menus
{
	public abstract class UnityEventAdapter : MonoBehaviour
	{
		[SerializeField] private Button _button;

		private void OnEnable() => _button.onClick.AddListener(OnButtonClick);
		
		private void OnDisable() => _button.onClick.RemoveListener(OnButtonClick);

		protected abstract void OnButtonClick();
	}
}
using Code.Unity.ViewListeners;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.Receivers
{
	public class ButtonClickReceiver : MonoBehaviour
	{
		[SerializeField] private Button _button;
		[SerializeField] private BaseViewListener _viewListener;

		private void OnEnable() => _button.onClick.AddListener(OnButtonClick);
		
		private void OnDisable() => _button.onClick.RemoveListener(OnButtonClick);

		private void OnButtonClick() => _viewListener.Entity.isButtonClick = true;
	}
}
using Code.Unity.ViewListeners;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonClickReceiver : MonoBehaviour
	{
		[SerializeField] private BaseViewListener _viewListener;
		[SerializeField] private Button _button;
		
		private void OnEnable() => _button.onClick.AddListener(OnClick);

		private void OnDisable() => _button.onClick.RemoveListener(OnClick);

		private void OnClick() => _viewListener.Entity.isMouseDown = true;
	}
}
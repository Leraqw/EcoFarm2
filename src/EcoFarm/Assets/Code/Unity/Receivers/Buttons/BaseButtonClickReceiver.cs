using UnityEngine;
using UnityEngine.UI;

namespace Code
{
	public abstract class BaseButtonClickReceiver : MonoBehaviour
	{
		[SerializeField] private Button _button;

		protected GameContext Context => Contexts.sharedInstance.game;

		private void OnEnable() => _button.onClick.AddListener(OnButtonClick);
		
		private void OnDisable() => _button.onClick.RemoveListener(OnButtonClick);

		protected abstract void OnButtonClick();
	}
}
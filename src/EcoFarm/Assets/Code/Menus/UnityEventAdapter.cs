using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Code
{
	public abstract class UnityEventAdapter : MonoBehaviour
	{
		[FormerlySerializedAs("_button")] [SerializeField] protected Button Button;

		private void OnEnable() => Button.onClick.AddListener(OnButtonClick);
		
		private void OnDisable() => Button.onClick.RemoveListener(OnButtonClick);

		protected abstract void OnButtonClick();
	}
}
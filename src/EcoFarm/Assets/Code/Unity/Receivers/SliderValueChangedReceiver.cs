using Code.Unity.ViewListeners;
using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.Receivers
{
	public class SliderValueChangedReceiver : MonoBehaviour
	{
		[SerializeField] private Slider _slider;
		[SerializeField] private BaseViewListener _viewListener;

		private void OnEnable() => _slider.onValueChanged.AddListener(OnValueChanged);
		
		private void OnDisable() => _slider.onValueChanged.RemoveListener(OnValueChanged);

		private void OnValueChanged(float value) 
			=> _viewListener.Entity.AddIntValueChanged((int)value);
	}
}
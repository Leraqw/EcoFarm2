using UnityEngine;
using UnityEngine.UI;

namespace Code
{
	public class SliderValueView : BaseViewListener, ISliderValueListener
	{
		[SerializeField] private Slider _slider;

		public int Value => (int)_slider.value;

		private void OnEnable() => _slider.onValueChanged.AddListener(OnValueChanged);
		
		private void OnDisable() => _slider.onValueChanged.RemoveListener(OnValueChanged);

		protected override void AddListener(GameEntity entity) => entity.AddSliderValueListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasSliderValue;

		protected override void UpdateValue(GameEntity entity) => OnSliderValue(entity, entity.sliderValue.Value);

		public void OnSliderValue(GameEntity entity, float value) => _slider.value = value;

		private void OnValueChanged(float value) => Entity.ReplaceSliderValue(value);
	}
}
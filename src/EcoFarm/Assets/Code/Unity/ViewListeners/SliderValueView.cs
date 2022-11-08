using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners
{
	public class SliderValueView : BaseViewListener, ISliderValueListener
	{
		[SerializeField] private Slider _slider;

		protected override void AddListener(GameEntity entity) => entity.AddSliderValueListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasSliderValue;

		protected override void UpdateValue(GameEntity entity) => OnSliderValue(entity, entity.sliderValue);

		public void OnSliderValue(GameEntity entity, float value) => _slider.value = value;
	}
}
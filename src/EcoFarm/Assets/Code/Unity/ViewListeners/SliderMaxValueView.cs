using UnityEngine;
using UnityEngine.UI;

namespace Code.Unity.ViewListeners
{
	public class SliderMaxValueView : BaseViewListener, ISliderMaxValueListener
	{
		[SerializeField] private Slider _slider;

		protected override void AddListener(GameEntity entity) => entity.AddSliderMaxValueListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasSliderMaxValue;

		protected override void UpdateValue(GameEntity entity) => OnSliderMaxValue(entity, entity.sliderMaxValue);

		public void OnSliderMaxValue(GameEntity entity, float value) => _slider.maxValue = value;
	}
}
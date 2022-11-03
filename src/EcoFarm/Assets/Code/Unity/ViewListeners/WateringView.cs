using UnityEngine;
using UnityEngine.UI;
using static Code.Utils.StaticClasses.Constants.Balance.Tree;

namespace Code.Unity.ViewListeners
{
	public class WateringView : BaseViewListener, IWateringListener
	{
		[SerializeField] private Slider _slider;

		protected override void AddListener(GameEntity entity) => entity.AddWateringListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasWatering;

		protected override void UpdateValue(GameEntity entity)
		{
			_slider.minValue = MinWatering;
			_slider.maxValue = MaxWatering;
			OnWatering(entity, entity.watering.Value);
		}

		public void OnWatering(GameEntity entity, int value) => _slider.value = value;
	}
}
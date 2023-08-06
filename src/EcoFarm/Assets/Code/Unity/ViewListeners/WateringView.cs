

using UnityEngine;
using UnityEngine.UI;
using static Contexts;

namespace EcoFarm
{
	public class WateringView : BaseViewListener, IWateringListener
	{
		[SerializeField] private Slider _slider;

		private static ITreeConfig ConfigurationTree => sharedInstance.GetConfiguration().Balance.Tree;
		
		protected override void AddListener(GameEntity entity) => entity.AddWateringListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasWatering;

		protected override void UpdateValue(GameEntity entity)
		{
			_slider.minValue = ConfigurationTree.MinWatering;
			_slider.maxValue = ConfigurationTree.MaxWatering;
			OnWatering(entity, entity.watering.Value);
		}

		public void OnWatering(GameEntity entity, int value) => _slider.value = value;
	}
}
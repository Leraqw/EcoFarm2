using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace EcoFarm
{
	public class WateringView : BaseViewListener, IWateringListener
	{
		[SerializeField] private Slider _slider;

		private IConfigurationService _configuration;

		private ITreeConfig TreeConfig => _configuration.Balance.Tree;

		[Inject]
		public void Construct(IConfigurationService configurationService)
			=> _configuration = configurationService;

		protected override void AddListener(GameEntity entity) => entity.AddWateringListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasWatering;

		protected override void UpdateValue(GameEntity entity)
		{
			_slider.minValue = TreeConfig.MinWatering;
			_slider.maxValue = TreeConfig.MaxWatering;
			OnWatering(entity, entity.watering.Value);
		}

		public void OnWatering(GameEntity entity, int value) => _slider.value = value;

		public class Factory : PlaceholderFactory<WateringView> { }
	}
}
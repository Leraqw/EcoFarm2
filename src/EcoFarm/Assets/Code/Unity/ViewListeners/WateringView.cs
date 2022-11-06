using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;
using UnityEngine.UI;
using static Contexts;

namespace Code.Unity.ViewListeners
{
	public class WateringView : BaseViewListener, IWateringListener
	{
		[SerializeField] private Slider _slider;

		private static ITreeConfig ConfigTree => sharedInstance.GetConfiguration().Balance.Tree;
		
		protected override void AddListener(GameEntity entity) => entity.AddWateringListener(this);

		protected override bool HasComponent(GameEntity entity) => entity.hasWatering;

		protected override void UpdateValue(GameEntity entity)
		{
			_slider.minValue = ConfigTree.MinWatering;
			_slider.maxValue = ConfigTree.MaxWatering;
			OnWatering(entity, entity.watering.Value);
		}

		public void OnWatering(GameEntity entity, int value) => _slider.value = value;
	}
}
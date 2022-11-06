using System;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Code.Unity.SO.Configuration.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[SerializeField] private WateringConfig _watering;
		[SerializeField] private TreeConfig _tree;
		[SerializeField] private BucketConfig _bucket;
		[SerializeField] private WarehouseConfig _warehouse;
		[SerializeField] private FruitConfig _fruit;

		public IWateringConfig Watering => _watering;

		public ITreeConfig Tree => _tree;

		public IBucketConfig Bucket => _bucket;

		public IWarehouseConfig Warehouse => _warehouse;

		public IFruitConfig Fruit => _fruit;
	}
}
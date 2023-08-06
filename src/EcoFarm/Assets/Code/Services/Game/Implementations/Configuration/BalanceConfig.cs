using System;



using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[SerializeField] private WateringConfig _watering;
		[SerializeField] private TreeConfig _tree;
		[SerializeField] private BucketConfig _bucket;
		[SerializeField] private WarehouseConfig _warehouse;
		[SerializeField] private FruitConfig _fruit;
		[SerializeField] private ResourceBalanceConfig _water;
		[SerializeField] private ResourceBalanceConfig _energy;
		[SerializeField] private FactoryConfig _factory;

		public IWateringConfig Watering => _watering;

		public ITreeConfig Tree => _tree;

		public IBucketConfig Bucket => _bucket;

		public IWarehouseConfig Warehouse => _warehouse;

		public IFruitConfig Fruit => _fruit;

		public IBalanceResourceConfig Water => _water;

		public IBalanceResourceConfig Energy => _energy;

		public IFactoryConfig Factory => _factory;
	}
}
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

		public IWateringConfig Watering => _watering;

		public ITreeConfig Tree => _tree;

		public IBucketConfig Bucket => _bucket;

		public static class FruitConfig
		{
			public const float GrowingTime = 0.5f;
			public const float BeforeGrowingTime = 1f;
			public const float AfterGrowingTime = 0.5f;
			public const float FallTime = 0.25f;
			public static readonly Vector2 SpawnHeight = Vector2.up;
			public const float InitialScale = 0;
			public const float FullScale = 1;
		}

		public static class WarehouseConfig
		{
			public const float PickupDuration = 0.5f;
		}
	}
}
using System;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.BalanceConfigs;
using Code.Unity.SO.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Config
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[SerializeField] private WateringConfig _wateringConfig;
		[SerializeField] private TreeConfig _tree;

		public IWateringConfig Watering => _wateringConfig;

		public ITreeConfig Tree => _tree;

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

		public static class BucketConfig
		{
			public const float Radius = 1f;
		}
	}
}
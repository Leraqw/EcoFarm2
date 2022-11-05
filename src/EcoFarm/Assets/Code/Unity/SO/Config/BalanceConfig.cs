using System;
using Code.Services.Interfaces.Config;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Config
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[SerializeField] private WateringConfig _wateringConfig;

		public IWateringConfig Watering => _wateringConfig;

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

		public static class TreeConfig
		{
			public const int MinWatering = 0;
			public const int MaxWatering = 8;
			public const int InitialWatering = 3;
			public const int WateringStep = 1;
		}
	}

	[Serializable]
	public class WateringConfig : IWateringConfig
	{
		[field: SerializeField] public float DroughtDuration { get; private set; } = 10f;
	}
}
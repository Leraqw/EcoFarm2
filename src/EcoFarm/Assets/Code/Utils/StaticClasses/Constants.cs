using System.IO;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Utils.StaticClasses
{
	public static class Constants
	{
		public static string PathToStorage
			=> Path.Combine(Directory.GetCurrentDirectory(), RelativePath, $"{nameof(Storage)}.json");

		public static Vector2 ProductSpawnOffset => new(1f, -0.5f);
		public const int FactoryPollution = 25;

		private const string RelativePath = "Assets/DataModel/SerializedFiles";

		public const string CoinItemName = "Coin";
		public const string WindmillName = "Windmill";
		public const string WaterCleanerName = "Water Cleaning Station";
		public const string ElectricityName = "Electricity";
		public const string WaterName = "Water";
		public const float CleaningTime = 1;
		public const float SpriteHighDelta = 0.01f;
		public const float SpriteNormalHigh = 1f;
	}
}
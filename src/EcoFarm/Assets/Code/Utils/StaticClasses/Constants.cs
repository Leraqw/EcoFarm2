using System.IO;
using EcoFarmModel;
using UnityEngine;
using static UnityEngine.Application;

namespace EcoFarm
{
	public static class Constants
	{
		public static string PathToStorage => Path.Combine(persistentDataPath, $"{nameof(Storage)}.json");
		public static string PathToPlayers => Path.Combine(persistentDataPath, "Players.json");

		public static Vector2 ProductSpawnOffset => new(1f, -0.5f);
		public const int FactoryPollution = 25;

		public const string CoinItemName = "Монета";
		public const string WindmillName = "Ветрогенератор";
		public const string WaterCleanerName = "Водоочистная станция";
		public const string ElectricityName = "Электричество";
		public const string WaterName = "Вода";

		public static class SpriteHigh
		{
			public const float DeltaStep = 0.05f;
			public const float DeltaMax = 0.25f;
			public const float Normal = 1f;
		}

	}
}
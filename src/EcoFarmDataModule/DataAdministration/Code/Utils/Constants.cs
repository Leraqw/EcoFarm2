using System.IO;

namespace DataAdministration
{
	public static class Constants
	{
		public const string CoinItemName = "Coin";
		public const string WindmillName = "Windmill";
		public const string WaterCleanerName = "Water Cleaning Station";
		public const string ElectricityName = "Electricity";
		public const string WaterName = "Water";

		public static string DbPath => Path.Combine(Directory.GetCurrentDirectory(), "EcoFarm.db");
	}
}
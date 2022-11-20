using System.IO;
using EcoFarmDataModule;
using UnityEngine;

namespace Code.Utils.StaticClasses
{
	public static class Constants
	{
		public static string PathToStorage
			=> Path.Combine(Directory.GetCurrentDirectory(), RelativePath, $"{nameof(Storage)}.json");

		public static Vector2 ProductSpawnOffset => new(0.2f, -0.1f);

		private const string RelativePath = "Assets/DataModel/SerializedFiles";
		
		public const string CoinItemName = "Coin";
	}
}
using System.IO;
using EcoFarmDataModule;

namespace Code.Utils.StaticClasses
{
	public static class Constants
	{
		public static string PathToStorage
			=> Path.Combine(Directory.GetCurrentDirectory(), RelativePath, $"{nameof(Storage)}.json");

		private const string RelativePath = "Assets/DataModel/SerializedFiles";
	}
}
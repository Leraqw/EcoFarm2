using UnityEditor;
using UnityEngine;

namespace Code.Data
{
	public static class UnityConfigurationsCreator
	{
		private const int TreesCount = 5;

		private static readonly Config Config;
		private static readonly IStorage Storage;

		static UnityConfigurationsCreator()
		{
			Config = new Config(TreesCount);
			Storage = new UnityJsonStorage();
		}

		[MenuItem("Tools/Eco-Farm/Create Config with 5 trees")]
		public static void CreateConfig() => Storage.Save(Config);

		[MenuItem("Tools/Eco-Farm/Load config")]
		public static void LoadConfig() => Debug.Log("loaded.TreesCount = " + Storage.Load(Config.Default).TreesCount);

		[MenuItem("Tools/Eco-Farm/Delete")] public static void DeleteConfig() => Storage.Delete<Config>();
	}
}
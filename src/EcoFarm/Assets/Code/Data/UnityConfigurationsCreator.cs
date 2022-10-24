using UnityEditor;
using UnityEngine;

namespace Code.Data
{
	public static class UnityConfigurationsCreator
	{
		private const int TreesCount = 5;

		[MenuItem("Tools/Eco-Farm/Create Config with 5 trees")]
		public static void CreateConfiguration()
		{
			var config = new Config(TreesCount);
			var storage = new UnityJsonStorage<Config>();
			
			storage.Save(config);

			var loaded = storage.Load(Config.Default);
			Debug.Log("loaded.TreesCount = " + loaded.TreesCount);
		}
	}
}
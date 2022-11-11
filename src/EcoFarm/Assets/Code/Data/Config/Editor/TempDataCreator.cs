using System.IO;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;

namespace Code.Data.Config.Editor
{ 
	public static class TempDataCreator
	{
		private const string RelativePath = "Assets/DataModel/SerializedFiles";

		public static void Create()
		{
			var storage = new Storage
			{
				Levels = new[] { new Level { Order = 1, TreesCount = 5 } }
			};

			var json = JsonConvert.SerializeObject(storage, Formatting.Indented);
			var path = Path.Combine(Directory.GetCurrentDirectory(), RelativePath, "storage.json");

			File.WriteAllText(path, json);
			Debug.Log($"File created on {path}");
		}
	}
}
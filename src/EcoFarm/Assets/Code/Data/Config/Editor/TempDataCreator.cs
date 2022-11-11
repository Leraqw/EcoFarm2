using System.IO;
using Code.Utils.StaticClasses;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;

namespace Code.Data.Config.Editor
{ 
	public static class TempDataCreator
	{
		public static void Create()
		{
			var storage = new Storage
			{
				Levels = new[] { new Level { Order = 1, TreesCount = 5 } }
			};

			var json = JsonConvert.SerializeObject(storage, Formatting.Indented);
			var path = Constants.PathToStorage;

			File.WriteAllText(path, json);
			Debug.Log($"File created on {path}");
		}
	}
}
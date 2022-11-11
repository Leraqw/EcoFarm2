using System.IO;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;

namespace Code.Data.Config.Editor
{
	public static class TempDataCreator
	{
		public static void Create() => Serialization(NewStorage());

		private static Storage NewStorage()
			=> new()
			{
				Levels = new[] { new Level { Order = 1, TreesCount = 5 } }
			};

		private static void Serialization(Storage storage)
		{
			File.WriteAllText(PathToStorage, SerializeObject(storage));
			Debug.Log($"File created on {PathToStorage}");
		}

		private static string SerializeObject(Storage storage) 
			=> JsonConvert.SerializeObject(storage, Formatting.Indented);
	}
}
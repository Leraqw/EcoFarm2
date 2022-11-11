using System.IO;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;
using Tree = EcoFarmDataModule.Tree;

namespace Code.Data.Config.Editor
{
	public static class TempDataCreator
	{
		public static void Create() => Serialization(NewStorage());

		private static Storage NewStorage()
		{
			var tree = new Tree
			{
				Product = new Product
				{
					Title = "Apple",
					Description = "Is a sweet, edible fruit produced by an apple tree.",
					Price = 10,
				}
			};
			
			return new Storage
			{
				Levels = new[] { new Level { Order = 1, TreesCount = 5 } }
			};
		}

		private static void Serialization(Storage storage)
		{
			File.WriteAllText(PathToStorage, SerializeObject(storage));
			Debug.Log($"File created on {PathToStorage}");
		}

		private static string SerializeObject(Storage storage) 
			=> JsonConvert.SerializeObject(storage, Formatting.Indented);
	}
}
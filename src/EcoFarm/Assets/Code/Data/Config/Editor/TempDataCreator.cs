using System.IO;
using EcoFarmDataModule;
using Newtonsoft.Json;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;
using static Newtonsoft.Json.PreserveReferencesHandling;
using Tree = EcoFarmDataModule.Tree;

namespace Code.Data.Config.Editor
{
	public static class TempDataCreator
	{
		private static JsonSerializerSettings WithReferences => new() { PreserveReferencesHandling = Objects };

		public static void Create() => Serialization(NewStorage());

		private static Storage NewStorage()
		{
			var apple = new Product
			{
				Title = "Apple",
				Description = "Is a sweet, edible fruit produced by an apple tree.",
				Price = 2,
			};

			return new Storage
			{
				Levels = new[]
				{
					new Level
					{
						Order = 1,
						TreesCount = 5,
						Goals = new Goal[]
						{
							new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 5 }
						}
					}
				},
				Trees = new[]
				{
					new Tree
					{
						Title = "Apple Tree",
						Description = "Giving apples",
						Product = apple
					}
				}
			};
		}

		private static void Serialization(Storage storage)
		{
			File.WriteAllText(PathToStorage, SerializeObject(storage));
			Debug.Log($"File created on {PathToStorage}");
		}

		private static string SerializeObject(Storage storage)
			=> JsonConvert.SerializeObject(storage, Formatting.Indented, WithReferences);
	}
}
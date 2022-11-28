using System.IO;
using EcoFarmModel;
using Newtonsoft.Json;
using UnityEngine;
using static Code.Data.StorageJson.JsonUtils;
using static Code.Utils.StaticClasses.Constants;
using Tree = EcoFarmModel.Tree;

namespace Code.Unity.TEMP
{
	public static class TempDataCreator
	{
		public static void Create() => Serialize(NewStorage(), PathToStorage);

		public static void Serialize(object data, string path)
		{
			File.WriteAllText(path, SerializeObject(data));
			Debug.Log($"File created on {path}");
		}

		private static string SerializeObject(object data)
			=> JsonConvert.SerializeObject(data, Formatting.Indented, WithReferences);

		private static Storage NewStorage()
		{
			CreateProducts(out var apple, out var coin, out var juice);
			CreateResources(out var electricity, out var water);
			var levels = CreateLevels(apple, coin, juice);

			return new Storage
			{
				Resources = new[]
				{
					electricity,
					water,
				},
				Products = new[]
				{
					coin,
					apple,
					juice,
				},

				Levels = levels,
				Trees = new[]
				{
					new Tree
					{
						Title = "Яблыня",
						Description = "Даёт яблоки",
						Product = apple,
					},
				},
				Buildings = new Building[]
				{
					new FactoryBuilding
					{
						Title = "Яблочный завод",
						Description = "Производит одну бутылку сока из 5-ти яблок",
						Price = 20,
						InputProducts = new[] { apple, apple, apple, apple, apple, },
						OutputProducts = new[] { juice },
						Resource = electricity,
						ResourceConsumptionCoefficient = 20,
					},
					new Generator
					{
						Title = WindmillName,
						Description = "Вырабатывает электричество",
						Price = 25,
						Resource = electricity,
						EfficiencyCoefficient = 2,
					},
					new Generator
					{
						Title = WaterCleanerName,
						Description = "Очищает воду от завода",
						Price = 25,
						Resource = water,
						EfficiencyCoefficient = 30,
					},
				},
			};
		}

		private static Level[] CreateLevels(Product apple, Product coin, Product juice)
		{
			var levels = new[]
			{
				new Level
				{
					Order = 1,
					TreesCount = 9,
					SecondsForLevel = 120,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 6 },
					},
				},
				new Level
				{
					Order = 2,
					TreesCount = 6,
					SecondsForLevel = 120,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 10 },
					},
				},
				new Level
				{
					Order = 3,
					TreesCount = 6,
					SecondsForLevel = 500,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 5 },
						new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 15 },
					},
				},
				new Level
				{
					Order = 4,
					TreesCount = 5,
					SecondsForLevel = 270,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = juice, TargetQuantity = 1 },
					},
				},
				new Level
				{
					Order = 5,
					TreesCount = 7,
					SecondsForLevel = 220,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 50 },
					},
				},
				new Level
				{
					Order = 6,
					TreesCount = 7,
					SecondsForLevel = 220,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = juice, TargetQuantity = 3 },
						new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 45 },
					},
				},
				new Level
				{
					Order = 7,
					TreesCount = 7,
					SecondsForLevel = 220,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = juice, TargetQuantity = 7 },
					},
				},
				new Level
				{
					Order = 8,
					TreesCount = 5,
					SecondsForLevel = 360,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 5 },
						new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 15 },
						new GoalByDevelopmentObject { DevelopmentObject = juice, TargetQuantity = 10 },
					},
				},
			};
			return levels;
		}

		private static void CreateResources(out Resource electricity, out Resource water)
		{
			electricity = new Resource
			{
				Title = ElectricityName,
				Description = "Это электричество",
			};

			water = new Resource
			{
				Title = WaterName,
				Description = "Это вода.",
			};
		}

		private static void CreateProducts(out Product apple, out Product coin, out Product juice)
		{
			apple = new Product
			{
				Title = "Яблоко",
				Description = "Яблоко, что растёт на дереве",
				Price = 2,
			};

			coin = new Product
			{
				Title = CoinItemName,
				Description = "Здешняя валюта",
				Price = 1,
			};

			juice = new Product
			{
				Title = "Яблочный сок",
				Description = "Сок из яблок",
				Price = 15,
			};
		}
	}
}
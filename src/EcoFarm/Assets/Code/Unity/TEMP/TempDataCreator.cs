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
						Title = "Apple Tree",
						Description = "Giving apples",
						Product = apple,
					},
				},
				Buildings = new Building[]
				{
					new FactoryBuilding
					{
						Title = "Apple Juice Factory",
						Description = "Making 1 apple juice from 5 apples",
						Price = 20,
						InputProducts = new[] { apple, apple, apple, apple, apple, },
						OutputProducts = new[] { juice },
						Resource = electricity,
						ResourceConsumptionCoefficient = 20,
					},
					new Generator
					{
						Title = WindmillName,
						Description = "Generating Electricity",
						Price = 25,
						Resource = electricity,
						EfficiencyCoefficient = 2,
					},
					new Generator
					{
						Title = WaterCleanerName,
						Description = "Generating Water",
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
					SecondsForLevel = 300,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = apple, TargetQuantity = 6 },
					},
				},
				new Level
				{
					Order = 2,
					TreesCount = 6,
					SecondsForLevel = 300,
					Goals = new Goal[]
					{
						new GoalByDevelopmentObject { DevelopmentObject = coin, TargetQuantity = 10 },
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
						new GoalByDevelopmentObject { DevelopmentObject = juice, TargetQuantity = 2 },
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
				Description
					= "Is the set of physical phenomena associated with the presence and motion of matter that has a property of electric charge.",
			};

			water = new Resource
			{
				Title = WaterName,
				Description
					= "Is a transparent, tasteless, odorless, and nearly colorless chemical substance, which is the main constituent of Earth's streams, lakes, and oceans, and the fluids of most living organisms.",
			};
		}

		private static void CreateProducts(out Product apple, out Product coin, out Product juice)
		{
			apple = new Product
			{
				Title = "Apple",
				Description = "Is a sweet, edible fruit produced by an apple tree.",
				Price = 2,
			};

			coin = new Product
			{
				Title = CoinItemName,
				Description = "Is a medium of exchange, a unit of account, and a store of value.",
				Price = 1,
			};

			juice = new Product
			{
				Title = "Juice",
				Description
					= "Is a liquid that is produced by squeezing or macerating fruit and sometimes also by pressing grapes.",
				Price = 10,
			};
		}
	}
}
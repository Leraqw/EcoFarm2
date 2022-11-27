using System;
using System.Collections.Generic;
using DataAdministration.Tables;
using Building = DataAdministration.Tables.Building;
using DevelopmentObject = DataAdministration.Tables.DevelopmentObject;
using Generator = DataAdministration.Tables.Generator;
using Goal = DataAdministration.Tables.Goal;
using Level = DataAdministration.Tables.Level;
using Product = DataAdministration.Tables.Product;
using Resource = DataAdministration.Tables.Resource;
using Tree = DataAdministration.Tables.Tree;

namespace DataAdministration
{
	public class TablesCollection
	{
		// ReSharper disable once InconsistentNaming
		private static readonly List<Type> _types;

		static TablesCollection()
		{
			_types = new List<Type>
			{
				typeof(Building),
				typeof(DevelopmentObject),
				typeof(DevelopmentObjectOnLevelStartup),
				typeof(Factory),
				typeof(Generator),
				typeof(Goal),
				typeof(GoalByDo),
				typeof(InputProducts),
				typeof(Level),
				typeof(OutputProducts),
				typeof(Product),
				typeof(Resource),
				typeof(ResourceForBuilding),
				typeof(Tree),
				typeof(User),
				typeof(UserProgress),
			};
		}

		public static IEnumerable<Type> Types => _types;
	}
}
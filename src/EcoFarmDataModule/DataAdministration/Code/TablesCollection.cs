using System;
using System.Collections.Generic;
using DataAdministration.Tables;

namespace DataAdministration
{
	public class TablesCollection
	{
		private readonly List<Type> _types;

		public TablesCollection()
		{
			_types = new List<Type>
			{
				typeof(Building),
				typeof(DevelopmentObject),
				typeof(DevelopmentObjectOnLevelStartup),
				typeof(Factory),
				typeof(Generator),
				typeof(Goal),
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

		public IEnumerable<Type> Types => _types;
	}
}
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
			_types = new List<Type>()
			         .Add<Building>()
			         .Add<DevelopmentObject>()
			         .Add<DevelopmentObjectOnLevelStartup>()
			         .Add<Factory>()
			         .Add<Generator>()
			         .Add<Goal>()
			         .Add<InputProducts>()
			         .Add<Level>()
			         .Add<OutputProducts>()
			         .Add<Product>()
			         .Add<Resource>()
			         .Add<ResourceForBuilding>()
			         .Add<Tree>()
			         .Add<User>()
			         .Add<UserProgress>()
				;
		}

		public IEnumerable<Type> Types => _types;
	}
}
using System.Collections.Generic;
using System.Linq;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

namespace DataAdministration
{
	public static class StorageExtensions
	{
		public static int Id;
		public static List<object> Results;

		public static List<object> ToTables(this Model.Storage @this)
		{
			Results = new List<object>();

			Results.AddRange(@this.Buildings.Select(AsTable.DO));
			Results.AddRange(@this.Products.Select(AsTable.DO));
			Results.AddRange(@this.Trees.Select(AsTable.DO));
			
			Results.AddRange(@this.Resources.Select(AsTable.Resource));
			Results.AddRange(@this.Products.Select(AsTable.Product));
			Results.AddRange(@this.Levels.Select(AsTable.Level));
			Results.AddRange(@this.Trees.Select(AsTable.Tree));
			Results.AddRange(@this.Buildings.Select(AsTable.Building));

			return Results;
		}
	}
}
using System.Collections.Generic;
using System.Linq;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

namespace DataAdministration
{
	public static class StorageExtensions
	{
		public static int Id;
		public static List<object> Result;

		public static List<object> ToTables(this Model.Storage @this)
		{
			Result = new List<object>();

			var resources = @this.Resources;
			var products = @this.Products;
			var levels = @this.Levels;
			var trees = @this.Trees;
			var buildings = @this.Buildings;

			Result.AddRange(ConvertResources(resources));
			Result.AddRange(ConvertProducts(products));
			Result.AddRange(ConvertLevels(levels));
			Result.AddRange(ConvertTrees(trees));

			return Result;
		}

		private static IEnumerable<object> ConvertResources(IEnumerable<Model.Resource> resources)
			=> resources.Select(AsTable.Resource);

		private static IEnumerable<object> ConvertProducts(IEnumerable<Model.Product> products)
			=> products.Select(AsTable.Product);

		private static IEnumerable<object> ConvertLevels(IEnumerable<Model.Level> levels)
			=> levels.Select(AsTable.Level);

		private static IEnumerable<object> ConvertTrees(IEnumerable<Model.Tree> trees) => trees.Select(AsTable.Tree);
	}
}
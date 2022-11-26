using System.Collections.Generic;
using System.Linq;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

namespace DataAdministration
{
	public static class StorageExtensions
	{
		public static int Id;

		public static List<object> ToTables(this Model.Storage @this)
		{
			var result = new List<object>();

			var resources = @this.Resources;
			var products = @this.Products;
			var levels = @this.Levels;
			var trees = @this.Trees;
			var buildings = @this.Buildings;

			result.AddRange(ConvertResources(resources));
			result.AddRange(ConvertProducts(products));

			return result;
		}

		private static IEnumerable<object> ConvertResources(IEnumerable<Model.Resource> resources)
			=> resources.Select(AsTable.Resource);

		private static IEnumerable<object> ConvertProducts(IEnumerable<Model.Product> products)
			=> products.Select(AsTable.Product);
	}
}
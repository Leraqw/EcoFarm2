using System.Linq;
using static DataAdministration.StorageExtensions;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

namespace DataAdministration
{
	public static class AsTable
	{
		public static Table.Resource Resource(Model.Resource resource)
			=> new Table.Resource
			{
				Id = Id++,
				Title = resource.Title,
				Description = resource.Description,
			};

		public static Table.Product Product(Model.Product product)
			=> new Table.Product
			{
				Id = Id++,
				Title = product.Title,
				Description = product.Description,
				Price = product.Price,
			};

		public static Table.Level Level(Model.Level level)
			=> new Table.Level
			{
				Id = Id++,
				Order = level.Order,
			};

		public static Table.Tree Tree(Model.Tree tree)
			=> new Table.Tree
			{
				Id = Id++,
				Title = tree.Title,
				Description = tree.Description,
				Price = tree.Price,
				ProductId = tree.GetProduct().Id,
			};

		public static Table.Building Building(Model.Building building)
			=> new Table.Building
			{
				Id = Id++,
				Title = building.Title,
				Description = building.Description,
				Price = building.Price,
			};
	}

	public static class ModelExtensions
	{
		public static Table.Product GetProduct(this Model.Tree @this)
			=> Results.OfType<Table.Product>().Single((p) => p.Title == @this.Product.Title);
	}
}
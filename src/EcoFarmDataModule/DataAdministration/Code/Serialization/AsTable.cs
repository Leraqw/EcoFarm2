using System.Linq;
using static DataAdministration.StorageExtensions;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

namespace DataAdministration
{
	public static class AsTable
	{
		public static Table.Resource Resource(Model.Resource _) => new Table.Resource { Id = Id++ };

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
	}

	public static class ModelExtensions
	{
		public static Table.Product GetProduct(this Model.Tree @this) 
			=> Result.OfType<Table.Product>().Single((p) => p.Title == @this.Product.Title);
	}
}
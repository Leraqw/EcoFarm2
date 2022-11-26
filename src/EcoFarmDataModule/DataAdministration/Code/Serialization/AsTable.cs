using System.Linq;
using static DataAdministration.StorageExtensions;
using Model = EcoFarmModel;
using Table = DataAdministration.Tables;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

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

		public static Table.Product Product(Model.Product product) => new Table.Product { Id = Id++, };

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
				ProductId = tree.GetProduct().Id,
			};

		public static Table.Building Building(Model.Building building) => new Table.Building { Id = Id++, };

		public static Table.DevelopmentObject DO(Model.DevelopmentObject @do)
			=> new Table.DevelopmentObject
			{
				Title = @do.Title,
				Description = @do.Description,
				Price = @do.Price,
			};
	}

	public static class ModelExtensions
	{
		public static Table.Product GetProduct(this Model.Tree @this)
		{
			// get id of DevelopmentProduct where product name is same as tree's product name
			var id = Results.OfType<Table.DevelopmentObject>().Single(p => p.Title == @this.Product.Title).Id;
			return Results.OfType<Table.Product>().Single(p => p.Id == id);
		}
	}
}
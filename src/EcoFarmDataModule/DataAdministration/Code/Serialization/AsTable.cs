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
	}
}
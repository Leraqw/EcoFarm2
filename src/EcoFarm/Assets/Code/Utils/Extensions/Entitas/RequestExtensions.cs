using System.Collections.Generic;
using System.Linq;
using EcoFarmModel;

namespace Code.Utils.Extensions.Entitas
{
	public static class RequestExtensions
	{
		public static Dictionary<Product, int> RequiredProducts(this GameEntity @this)
			=> @this.GetGroups().AsDictionary();

		private static IEnumerable<IGrouping<Product, Product>> GetGroups(this GameEntity @this)
			=> @this.factory.Value.InputProducts.GroupBy((x) => x);

		private static Dictionary<Product, int> AsDictionary(this IEnumerable<IGrouping<Product, Product>> @this)
			=> @this.ToDictionary(x => x.Key, x => x.Count());
	}
}
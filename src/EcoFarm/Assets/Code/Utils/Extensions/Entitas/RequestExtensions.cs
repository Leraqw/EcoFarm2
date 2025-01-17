﻿using System.Collections.Generic;
using System.Linq;

namespace EcoFarm
{
	public static class RequestExtensions
	{
		public static Dictionary<Product, int> RequiredProducts(this GameEntity @this)
			=> @this.GetGroups().AsDictionary();

		private static IEnumerable<IGrouping<Product, Product>> GetGroups(this GameEntity @this)
			=> @this.factory.Value.InputProducts.GroupBy((x) => x);

		private static Dictionary<T, int> AsDictionary<T>(this IEnumerable<IGrouping<T, T>> @this)
			=> @this.ToDictionary(x => x.Key, x => x.Count());
	}
}
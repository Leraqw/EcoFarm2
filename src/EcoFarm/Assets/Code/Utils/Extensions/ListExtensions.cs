using System;
using System.Collections.Generic;
using System.Linq;

namespace EcoFarm
{
	public static class ListExtensions
	{
		// ReSharper disable once ParameterTypeCanBeEnumerable.Global - extension must be on List
		public static void ForEach<T>(this List<T> @this, Action<T> @do, Func<T, bool> @if)
		{
			foreach (var item in @this.Where(@if))
			{
				@do(item);
			}
		}
	}
}
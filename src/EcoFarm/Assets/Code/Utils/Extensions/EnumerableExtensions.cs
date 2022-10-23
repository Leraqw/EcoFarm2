using System;
using System.Collections.Generic;

namespace Code.Utils.Extensions
{
	public static class EnumerableExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> @this, Action<T> @do)
		{
			foreach (var item in @this)
			{
				@do(item);
			}
		}
	}
}
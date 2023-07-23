using System;
using System.Collections.Generic;

namespace Code
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
		
		public static void ForEach<T>(this IEnumerable<T> @this, Action<T> @do, Func<T, bool> @if)
		{
			foreach (var item in @this)
			{
				if (@if(item))
				{
					@do(item);
				}
			}
		}
	}
}
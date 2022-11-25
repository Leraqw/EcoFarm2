using System;
using System.Collections.Generic;

namespace DataAdministration
{
	public static class ListExtensions
	{
		public static List<Type> Add<T>(this List<Type> list)
		{
			list.Add(typeof(T));
			return list;
		}
	}
}
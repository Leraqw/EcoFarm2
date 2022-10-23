using System;

namespace Code.Utils.Extensions
{
	public static class GenericExtensions
	{
		public static T Do<T>(this T @this, Action<T> action)
		{
			action(@this);
			return @this;
		}
	}
}
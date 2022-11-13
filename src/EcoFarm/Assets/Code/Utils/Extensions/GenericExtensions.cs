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

		public static T Do<T>(this T @this, Action<T> action, Func<T, bool> @if)
		{
			if (@if.Invoke(@this))
			{
				action.Invoke(@this);	
			}

			return @this;
		}
		
		public static T Do<T>(this T @this, Action<T> action, bool @if)
		{
			if (@if)
			{
				action.Invoke(@this);	
			}

			return @this;
		}
	}
}
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

		public static T Do<T>(this T @this, Func<T, bool> @if, Action<T> @true, Action<T> @false)
		{
			if (@if.Invoke(@this))
			{
				@true.Invoke(@this);
			}
			else
			{
				@false.Invoke(@this);
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
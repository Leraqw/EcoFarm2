using System;
using Entitas;

namespace Code
{
	public static class GameEntitiesExtensions
	{
		public static void ForEach<T>(this IGroup<T> @this, Action<T> action)
			where T : class, IEntity
		{
			foreach (var entity in @this.GetEntities())
			{
				action(entity);
			}
		}

		public static void ForEach<T>(this IGroup<T> @this, Action<T> action, Func<T, bool> @if)
			where T : class, IEntity
		{
			foreach (var entity in @this.GetEntities())
			{
				if (@if(entity))
				{
					action(entity);
				}
			}
		}
	}
}
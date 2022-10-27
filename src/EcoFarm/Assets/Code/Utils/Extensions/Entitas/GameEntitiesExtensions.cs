using System;
using Entitas;

namespace Code.Utils.Extensions.Entitas
{
	public static class GameEntitiesExtensions
	{
		public static void ForEach(this IGroup<GameEntity> @this, Action<GameEntity> action)
		{
			foreach (var entity in @this.GetEntities())
			{
				action(entity);
			}
		}
	}
}
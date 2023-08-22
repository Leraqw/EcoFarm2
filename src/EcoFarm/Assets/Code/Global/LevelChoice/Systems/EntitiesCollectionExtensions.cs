using System.Collections.Generic;
using Entitas;

namespace EcoFarm
{
	public static class EntitiesCollectionExtensions
	{
		public static void DestroyAll<TEntity>(this IEnumerable<TEntity> @this)
			where TEntity : Entity
		{
			foreach (var entity in @this)
			{
				entity.Destroy();
			}
		} 
	}
}
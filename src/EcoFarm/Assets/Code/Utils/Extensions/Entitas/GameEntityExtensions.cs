using UnityEngine;

namespace Code.Utils.Extensions.Entitas
{
	public static class GameEntityExtensions
	{
		public static Vector2 GetActualSpawnPosition(this GameEntity @this)
			=> @this.hasSpawnPosition ? @this.spawnPosition.Value
				: @this.hasPosition ? @this.position.Value
				: Vector2.zero;

		public static void PerformRequiredView(this GameEntity @this, GameObject gameObject)
		{
			@this.AddView(gameObject);
			if (@this.hasRequireView)
			{
				@this.RemoveRequireView();
			}
			else
			{
				@this.RemoveViewPrefab();
			}
		}

		public static Vector2 GetActualPosition(this GameEntity @this)
			=> @this.hasPosition ? @this.position.Value
				: @this.hasSpawnPosition ? @this.spawnPosition.Value
				: @this.hasView ? @this.view.Value.transform.position
				: Vector2.zero;

		public static void IncreaseProportionalScale(this GameEntity @this, float value) 
			=> @this.ReplaceProportionalScale(@this.proportionalScale.Value + value);
		
		public static void IncreasePosition(this GameEntity @this, Vector2 value) 
			=> @this.ReplacePosition(@this.position.Value + value);
	}
}
using UnityEngine;

namespace Code.Utils.Extensions.Generated
{
	public static class GameEntityExtensions
	{
		public static Vector2 GetActualSpawnPosition(this GameEntity @this)
			=> @this.hasSpawnPosition ? @this.spawnPosition.Value : Vector3.zero;

		public static void PerformRequiredView(this GameEntity @this, GameObject gameObject)
		{
			@this.AddView(gameObject);
			@this.RemoveRequireView();
		}
	}
}
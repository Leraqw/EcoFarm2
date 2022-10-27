using UnityEngine;

namespace Code.Utils.Extensions.Generated
{
	public static class GameEntityExtensions
	{
		public static Vector2 PopSpawnPosition(this GameEntity @this)
		{
			if (@this.hasSpawnPosition == false)
			{
				return Vector3.zero;
			}

			var value = @this.spawnPosition.Value;
			@this.RemoveSpawnPosition();
			return value;

		}

		public static void PerformRequiredView(this GameEntity @this, GameObject gameObject)
		{
			@this.AddView(gameObject);
			@this.RemoveRequireView();
		}
	}
}
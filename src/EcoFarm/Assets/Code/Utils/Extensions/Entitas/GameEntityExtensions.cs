using UnityEngine;

namespace Code.Utils.Extensions.Entitas
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

		public static Vector3 GetLocalScale(this GameEntity @this) => @this.view.Value.transform.localScale;

		public static void SetLocalScale(this GameEntity @this, Vector3 value)
			=> @this.view.Value.transform.localScale = value;
		
		public static Vector3 GetActualPosition(this GameEntity @this)
			=> @this.hasView ? @this.view.Value.transform.position : Vector3.zero;
	}
}
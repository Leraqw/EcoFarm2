using UnityEngine;

namespace Code.Utils.StaticClasses
{
	public static class GameObjectUtils
	{
		public static GameObject Instantiate(GameObject original, Vector2 position, Transform parent) 
			=> Object.Instantiate(original, position, Quaternion.identity, parent);
	}
}
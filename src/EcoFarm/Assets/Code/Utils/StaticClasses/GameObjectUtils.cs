using UnityEngine;

namespace Code
{
	public static class GameObjectUtils
	{
		public static GameObject Instantiate(GameObject original, Vector2 position, Transform parent) 
			=> Object.Instantiate(original, position, Quaternion.identity, parent);
	}
}
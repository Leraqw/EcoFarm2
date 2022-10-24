using UnityEngine;

namespace Code.Utils.StaticClasses
{
	public static class GameObjectUtils
	{
		public static void Instantiate(GameObject original, Vector2 position)
			=> Object.Instantiate(original, position, Quaternion.identity);
	}
}
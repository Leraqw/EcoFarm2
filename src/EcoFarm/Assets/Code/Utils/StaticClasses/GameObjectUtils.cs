using UnityEngine;
using UnityGameObject = UnityEngine.GameObject;

namespace EcoFarm.Utils
{
	public static class GameObject
	{
		public static UnityGameObject Instantiate(UnityGameObject original, Vector2 position, Transform parent)
			=> Object.Instantiate(original, position, Quaternion.identity, parent);
	}
}
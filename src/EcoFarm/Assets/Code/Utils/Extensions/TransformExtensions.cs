using UnityEngine;

namespace EcoFarm
{
	public static class TransformExtensions
	{
		public static void DestroyChildrens(this Transform transform)
		{
			foreach (Transform child in transform)
			{
				Object.Destroy(child.gameObject);
			}
		}
	}
}
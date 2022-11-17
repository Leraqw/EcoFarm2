using UnityEngine;

namespace Code.Utils.Extensions
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
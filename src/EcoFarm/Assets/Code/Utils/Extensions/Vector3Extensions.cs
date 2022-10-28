using UnityEngine;

namespace Code.Utils.Extensions
{
	public static class Vector3Extensions
	{
		public static int Compare(this Vector3 @this, Vector3 other) => @this.IsGreater(other) ? 1 : -1;

		public static bool IsGreater(this Vector3 @this, Vector3 other) 
			=> @this.x > other.x || @this.y > other.y || @this.z > other.z;
		
		public static bool IsLess(this Vector3 @this, Vector3 other)
			=> @this.x < other.x || @this.y < other.y || @this.z < other.z;
		
		public static float Avg(this Vector3 @this) => (@this.x + @this.y + @this.z) / 3;
	}
}
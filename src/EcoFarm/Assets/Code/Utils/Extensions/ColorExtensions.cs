using UnityEngine;

namespace EcoFarm
{
	public static class ColorExtensions
	{
		public static Color SetAlpha(this Color @this, float alpha) => new(@this.r, @this.g, @this.b, alpha);
	}
}
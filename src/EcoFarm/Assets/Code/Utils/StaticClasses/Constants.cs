using UnityEngine;

namespace Code.Utils.StaticClasses
{
	public static class Constants
	{
		public static class ResourcePath
		{
			public const string ApplePrefab = "Products/Fruits/Prefabs/Apple";
			public const string TreePrefab = "Trees/Prefabs/Tree";
			public const string BedPlugPrefab = "Environment/Trees Beds/Prefabs/Tree Bed Plug";
		}

		public static class Balance
		{
			public static class Fruit
			{
				public const float GrowingTime = 1f;
				public const float BeforeGrowingTime = 1f;
				public const float AfterGrowingTime = 1f;
				public static readonly Vector2 SpawnHeight = Vector2.up;
			}
		}
	}
}
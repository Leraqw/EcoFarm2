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
			public const string Warehouse = "Environment/Warehouse/Prefabs/Warehouse";
			public const string Crane = "Environment/Crane/Prefabs/Crane";
		}

		public static class Balance
		{
			public static class Fruit
			{
				public const float GrowingTime = 0.5f;
				public const float BeforeGrowingTime = 1f;
				public const float AfterGrowingTime = 0.5f;
				public const float FallTime = 0.25f;
				public static readonly Vector2 SpawnHeight = Vector2.up;
				public const float InitialScale = 0;
				public const float FullScale = 1;
			}

			public static class Warehouse
			{
				public const float PickupDuration = 0.5f;
			}
		}

		public const float Tolerance = 0.01f;

		public static class Temp
		{
			public const int AppleID = 1;
		}
	}
}
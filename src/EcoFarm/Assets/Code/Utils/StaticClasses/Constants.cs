﻿using UnityEngine;

namespace EcoFarm
{
	public static class Constants
	{
		public const string RootNamespace = nameof(EcoFarm) + "/";

		public static Vector2 ProductFabricOffset => new(1f, 0f);
		public static Vector2 ProductsOffset => new(-0.1f, -0.1f);
		public const int FactoryPollution = 25;

		public static class SpriteHigh
		{
			public const float DeltaStep = 0.05f;
			public const float DeltaMax = 0.25f;
			public const float Normal = 1f;
		}
	}
}
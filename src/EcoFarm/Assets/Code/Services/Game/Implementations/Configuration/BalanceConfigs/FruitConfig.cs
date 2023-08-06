using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class FruitConfig : IFruitConfig
	{
		[field: SerializeField] public float   GrowingTime       { get; private set; } = 0.5f;
		[field: SerializeField] public float   BeforeGrowingTime { get; private set; } = 1f;
		[field: SerializeField] public float   AfterGrowingTime  { get; private set; } = 0.5f;
		[field: SerializeField] public float   FallTime          { get; private set; } = 0.25f;
		[field: SerializeField] public Vector2 SpawnHeight       { get; private set; } = Vector2.up;
		[field: SerializeField] public float   InitialScale      { get; private set; }
		[field: SerializeField] public float   FullScale         { get; private set; } = 1;
	}
}
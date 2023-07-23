using UnityEngine;

namespace Code
{
	public interface IFruitConfig
	{
		float GrowingTime { get; }
		float BeforeGrowingTime { get; }
		float AfterGrowingTime { get; }
		float FallTime { get; }
		Vector2 SpawnHeight { get; }
		float InitialScale { get; }
		float FullScale { get; }
	}
}
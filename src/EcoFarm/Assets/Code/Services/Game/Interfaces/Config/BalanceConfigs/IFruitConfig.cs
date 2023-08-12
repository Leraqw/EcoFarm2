using UnityEngine;

namespace EcoFarm
{
	public interface IFruitConfig
	{
		float GrowingTime { get; }
		float BeforeGrowingTime { get; }
		float AfterGrowingTime { get; }
		float FallTime { get; }
		Vector2 SpawnOffset { get; }
		float InitialScale { get; }
		float FullScale { get; }
	}
}
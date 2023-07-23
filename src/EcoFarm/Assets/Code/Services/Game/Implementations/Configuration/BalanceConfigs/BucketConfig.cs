using System;

using UnityEngine;

namespace Code
{
	[Serializable]
	public class BucketConfig : IBucketConfig
	{
		[field: SerializeField] public float Radius           { get; private set; } = 1f;
		[field: SerializeField] public int   WaterConsumption { get; private set; } = 10;
	}
}
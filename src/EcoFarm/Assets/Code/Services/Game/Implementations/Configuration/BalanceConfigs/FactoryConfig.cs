using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class FactoryConfig : IFactoryConfig
	{
		[field: SerializeField] public float WorkingDuration           { get; private set; } = 1f;
		[field: SerializeField] public float SendProductToFactoryDelay { get; private set; } = 0.1f;
		[field: SerializeField] public float RoadToFactoryDuration     { get; private set; } = 1f;
	}
}
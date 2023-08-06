using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class WateringConfig : IWateringConfig
	{
		[field: SerializeField] public float DroughtDuration { get; private set; } = 10f;
		[field: SerializeField] public int   DroughtStep     { get; private set; } = 1;
		[field: SerializeField] public int   WateringStep    { get; private set; } = 1;
	}
}
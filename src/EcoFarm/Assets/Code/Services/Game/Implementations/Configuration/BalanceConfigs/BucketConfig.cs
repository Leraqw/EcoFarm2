using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.BalanceConfigs
{
	[Serializable]
	public class BucketConfig : IBucketConfig
	{
		[field: SerializeField] public float Radius           { get; private set; } = 1f;
		[field: SerializeField] public int   WaterConsumption { get; private set; } = 10;
	}
}
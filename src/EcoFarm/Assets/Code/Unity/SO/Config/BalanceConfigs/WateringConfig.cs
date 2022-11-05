using System;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Config.BalanceConfigs
{
	[Serializable]
	public class WateringConfig : IWateringConfig
	{
		[field: SerializeField] public float DroughtDuration { get; private set; } = 10f;
	}
}
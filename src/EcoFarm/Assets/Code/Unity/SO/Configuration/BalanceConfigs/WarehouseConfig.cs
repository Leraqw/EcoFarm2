using System;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.BalanceConfigs
{
	[Serializable]
	public class WarehouseConfig : IWarehouseConfig
	{
		[field: SerializeField] public float PickupDuration { get; private set; } = 0.5f;
	}
}
using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.BalanceConfigs
{
	[Serializable]
	public class WarehouseConfig : IWarehouseConfig
	{
		[field: SerializeField] public float PickupDuration { get; private set; } = 0.5f;
	}
}
using System;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.BalanceConfigs
{
	[Serializable]
	public class TreeConfig : ITreeConfig
	{
		[field: SerializeField] public int MinWatering { get; private set; }
		[field: SerializeField] public int MaxWatering { get; private set; } = 8;
		[field: SerializeField] public int InitialWatering { get; private set; } = 3;
		[field: SerializeField] public int WateringStep { get; private set; } = 1;
	}
}
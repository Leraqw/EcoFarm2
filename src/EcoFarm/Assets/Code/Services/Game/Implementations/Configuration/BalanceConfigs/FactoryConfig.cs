using System;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.BalanceConfigs
{
	[Serializable]
	public class FactoryConfig : IFactoryConfig
	{
		[field: SerializeField] public float WorkingDuration           { get; private set; } = 1f;
		[field: SerializeField] public float SendProductToFactoryDelay { get; private set; } = 0.1f;
		[field: SerializeField] public float RoadToFactoryDuration     { get; private set; } = 1f;
	}
}
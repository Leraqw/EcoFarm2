using System;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration.ResourcesConfigs
{
	[Serializable]
	public class WaterCleanerConfig : IWaterCleanerConfig
	{
		[field: SerializeField] public Sprite Clean { get; private set; }
		[field: SerializeField] public Sprite Dirty { get; private set; }
	}
}
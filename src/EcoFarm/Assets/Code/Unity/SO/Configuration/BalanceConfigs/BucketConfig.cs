using System;
using Code.Services.Interfaces.Config.BalanceConfigs;
using UnityEngine;

namespace Code.Unity.SO.Configuration.BalanceConfigs
{
	[Serializable]
	public class BucketConfig : IBucketConfig
	{
		[field: SerializeField] public float Radius { get; private set; } = 1f;
	}
}
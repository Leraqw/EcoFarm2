using System;
using Code.Services.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Config
{
	[Serializable]
	public class BalanceConfig : IBalanceConfig
	{
		[field: SerializeField] public float DroughtDuration { get; private set; }
	}
}
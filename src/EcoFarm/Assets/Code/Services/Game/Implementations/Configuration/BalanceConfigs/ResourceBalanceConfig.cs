using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class ResourceBalanceConfig : IBalanceResourceConfig
	{
		[field: SerializeField] public int MaxValue   { get; private set; } = 100;
		[field: SerializeField] public int StartValue { get; private set; } = 100;
		[field: SerializeField] public int RenewPrice { get; private set; } = 10;
	}
}
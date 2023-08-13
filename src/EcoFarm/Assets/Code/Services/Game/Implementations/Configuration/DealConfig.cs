using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	internal class DealConfig : IDealConfig
	{
		[field: SerializeField] public int CoinsPerApple { get; private set; } = 2;
	}
}
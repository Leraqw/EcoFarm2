using System;

using UnityEngine;

namespace Code
{
	[Serializable]
	internal class DealConfig : IDealConfig
	{
		[field: SerializeField] public int CoinsPerApple { get; private set; } = 2;
	}
}
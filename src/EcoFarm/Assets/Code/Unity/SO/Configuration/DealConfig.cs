using System;
using Code.Services.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	internal class DealConfig : IDealConfig
	{
		[field: SerializeField] public int CoinsPerApple { get; private set; } = 2;
	}
}
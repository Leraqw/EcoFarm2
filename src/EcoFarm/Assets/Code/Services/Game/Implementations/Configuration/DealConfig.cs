using System;
using Code.Services.Game.Interfaces.Config;
using UnityEngine;

namespace Code.Services.Game.Implementations.Configuration
{
	[Serializable]
	internal class DealConfig : IDealConfig
	{
		[field: SerializeField] public int CoinsPerApple { get; private set; } = 2;
	}
}
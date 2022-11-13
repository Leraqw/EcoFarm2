using System;
using Code.Services.Game.Interfaces.Config;
using UnityEngine;

namespace Code.Unity.SO.Configuration
{
	[Serializable]
	public class CommonConfig : ICommonConfig
	{
		[field: SerializeField] public float Tolerance { get; private set; } = 0.01f;
	}
}
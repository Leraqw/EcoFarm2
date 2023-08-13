using System;

using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class TreeConfig : ITreeConfig
	{
		[field: SerializeField] public int MinWatering     { get; private set; }
		[field: SerializeField] public int MaxWatering     { get; private set; } = 8;
		[field: SerializeField] public int InitialWatering { get; private set; } = 3;
	}
}
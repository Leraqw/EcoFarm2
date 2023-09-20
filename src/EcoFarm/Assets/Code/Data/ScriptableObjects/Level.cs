using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class Level
	{
		[field: SerializeField] public int    Order           { get; private set; }
		[field: SerializeField] public int    AppleTreesCount      { get; private set; }
		[field: SerializeField] public int    PearTreesCount      { get; private set; }
		[field: SerializeField] public int    SecondsForLevel { get; private set; }
		[field: SerializeField] public Goal[] Goals           { get; private set; }
	}
}
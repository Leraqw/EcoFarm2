using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class LevelSO
	{
		[field: SerializeField] public int    Order           { get; private set; }
		[field: SerializeField] public int    TreesCount      { get; private set; }
		[field: SerializeField] public int    SecondsForLevel { get; private set; }
		[field: SerializeField] public GoalSO[] Goals           { get; private set; }
	}
}
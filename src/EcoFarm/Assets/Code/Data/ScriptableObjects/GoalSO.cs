using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class GoalSO
	{
		[field: SerializeField] public int TargetQuantity { get; private set; }
	}
}
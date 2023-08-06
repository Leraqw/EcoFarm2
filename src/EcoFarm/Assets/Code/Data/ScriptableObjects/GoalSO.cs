using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class GoalSO
	{
		[field: SerializeField] public int TargetQuantity { get; private set; }
	}
}
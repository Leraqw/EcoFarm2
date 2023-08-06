using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class GoalByDevelopmentObjectSO : GoalSO
	{
		[field: SerializeField] public DevelopmentObjectSO DevelopmentObject { get; private set; }
	}
}
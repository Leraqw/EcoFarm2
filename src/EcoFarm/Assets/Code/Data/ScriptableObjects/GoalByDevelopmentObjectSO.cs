using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class GoalByDevelopmentObjectSO : GoalSO
	{
		[field: SerializeField] public DevelopmentObjectSO DevelopmentObject { get; private set; }
	}
}
using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class GoalByDevObjectByDevelopmentObjectSo : GoalByDevObjectSO
	{
		[field: SerializeField] public DevObjectSO DevObject { get; private set; }
	}
}
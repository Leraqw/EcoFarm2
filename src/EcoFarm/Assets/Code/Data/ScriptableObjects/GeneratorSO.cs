using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class GeneratorSO : BuildingSO
	{
		[field: SerializeField] public ResourceSO Resource              { get; private set; }
		[field: SerializeField] public int        EfficiencyCoefficient { get; private set; }
	}
}
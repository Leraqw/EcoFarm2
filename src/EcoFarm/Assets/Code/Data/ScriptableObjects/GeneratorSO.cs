using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class GeneratorSO : BuildingSO
	{
		[field: SerializeField] public ResourceSO Resource              { get; private set; }
		[field: SerializeField] public int        EfficiencyCoefficient { get; private set; }
	}
}
using System;
using UnityEngine;

namespace Code
{
	[Serializable]
	public class FactoryBuildingSO : BuildingSO
	{
		[field: SerializeField] public ProductSO[] InputProducts                  { get; private set; }
		[field: SerializeField] public ProductSO[] OutputProducts                 { get; private set; }
		[field: SerializeField] public ResourceSO  Resource                       { get; private set; }
		[field: SerializeField] public int         ResourceConsumptionCoefficient { get; private set; }
	}
}
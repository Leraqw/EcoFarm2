using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(FactorySO), menuName = Constants.RootNamespace + nameof(FactorySO))]
	public class FactorySO : BuildingSO
	{
		[field: SerializeField] public ProductSO[] InputProducts                  { get; private set; }
		[field: SerializeField] public ProductSO[] OutputProducts                 { get; private set; }
		[field: SerializeField] public ResourceSO  Resource                       { get; private set; }
		[field: SerializeField] public int         ResourceConsumptionCoefficient { get; private set; }
	}
}
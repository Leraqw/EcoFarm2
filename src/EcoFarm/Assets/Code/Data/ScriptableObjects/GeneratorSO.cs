using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(GeneratorSO), menuName = Constants.RootNamespace + nameof(GeneratorSO))]
	public class GeneratorSO : BuildingSO
	{
		[field: SerializeField] public ResourceSO Resource              { get; private set; }
		[field: SerializeField] public int        EfficiencyCoefficient { get; private set; }
	}
}
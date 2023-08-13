using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(Generator), menuName = Constants.RootNamespace + nameof(Generator))]
	public class Generator : Building
	{
		[field: SerializeField] public Resource Resource              { get; private set; }
		[field: SerializeField] public int        EfficiencyCoefficient { get; private set; }
	}
}
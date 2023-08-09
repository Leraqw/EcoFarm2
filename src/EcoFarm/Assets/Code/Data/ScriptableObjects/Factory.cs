using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(Factory), menuName = Constants.RootNamespace + nameof(Factory))]
	public class Factory : Building
	{
		[field: SerializeField] public Product[] InputProducts                  { get; private set; }
		[field: SerializeField] public Product[] OutputProducts                 { get; private set; }
		[field: SerializeField] public Resource  Resource                       { get; private set; }
		[field: SerializeField] public int         ResourceConsumptionCoefficient { get; private set; }
	}
}
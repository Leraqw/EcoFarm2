using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(TreeSO), menuName = Constants.RootNamespace + nameof(TreeSO))]
	public class TreeSO : DevObjectSO
	{
		[field: SerializeField] public ProductSO Product { get; private set; }
	}
}
using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(Tree), menuName = Constants.RootNamespace + nameof(Tree))]
	public class Tree : DevObject
	{
		[field: SerializeField] public Product Product { get; private set; }
	}
}
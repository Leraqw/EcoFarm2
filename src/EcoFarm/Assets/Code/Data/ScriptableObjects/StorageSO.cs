using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = "Storage", menuName = "EcoFarm/Storage")]
	public class StorageSO : ScriptableObject
	{
		[field: SerializeField] public ResourceSO[] Resources { get; private set; }
		[field: SerializeField] public ProductSO[]  Products  { get; private set; }
		[field: SerializeField] public LevelSO[]    Levels    { get; private set; }
		[field: SerializeField] public TreeSO[]     Trees     { get; private set; }
		[field: SerializeField] public BuildingSO[] Buildings { get; private set; }
	}
}
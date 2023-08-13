using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = nameof(Storage), menuName = Constants.RootNamespace + nameof(Storage))]
	public class Storage : ScriptableObject
	{
		[field: SerializeField] public Resource[] Resources { get; private set; }
		[field: SerializeField] public Product[]  Products  { get; private set; }
		[field: SerializeField] public Level[]    Levels    { get; private set; }
		[field: SerializeField] public Tree[]     Trees     { get; private set; }
		[field: SerializeField] public Building[] Buildings { get; private set; }
	}
}
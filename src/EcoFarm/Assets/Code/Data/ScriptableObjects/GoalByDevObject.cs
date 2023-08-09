using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu
	(
		fileName = nameof(GoalByDevObject),
		menuName = Constants.RootNamespace + "Goals" + nameof(GoalByDevObject)
	)]
	public class GoalByDevObject : Goal
	{
		[field: SerializeField] public int       TargetQuantity { get; private set; }
		[field: SerializeField] public DevObject DevObject      { get; private set; }
	}
}
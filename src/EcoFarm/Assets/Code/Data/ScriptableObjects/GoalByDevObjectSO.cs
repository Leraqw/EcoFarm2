using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu
	(
		fileName = nameof(GoalByDevObjectSO),
		menuName = Constants.RootNamespace + "Goals" + nameof(GoalByDevObjectSO)
	)]
	public class GoalByDevObjectSO : GoalSO
	{
		[field: SerializeField] public int         TargetQuantity { get; private set; }
		[field: SerializeField] public DevObjectSO DevObject      { get; private set; }
	}
}
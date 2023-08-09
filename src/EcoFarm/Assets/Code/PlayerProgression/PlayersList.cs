using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = "Players", menuName = Constants.RootNamespace + "Players")]
	public class PlayersList : ScriptableObject
	{
		[field: SerializeField] public List<PlayerSO> Players { get; private set; }
	}
}
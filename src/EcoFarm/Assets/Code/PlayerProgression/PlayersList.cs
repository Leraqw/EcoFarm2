using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
	[CreateAssetMenu(fileName = "Players", menuName = Constants.RootNamespace + "Players")]
	public class PlayersList : ScriptableObject
	{
		[field: SerializeField] public List<Player> Players { get; private set; }
	}
}
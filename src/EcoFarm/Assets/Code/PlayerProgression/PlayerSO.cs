using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class PlayerSO
	{
		[field: SerializeField] public string Nickname             { get; private set; }
		[field: SerializeField] public int    CompletedLevelsCount { get; private set; }
	}
}
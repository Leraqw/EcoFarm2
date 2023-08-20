using System;
using UnityEngine;

namespace EcoFarm
{
	[Serializable]
	public class Player
	{
		[field: SerializeField] public string Nickname             { get; private set; }
		[field: SerializeField] public int    CompletedLevelsCount { get; private set; }

		public Player(string nickname, int completedLevelsCount)
		{
			Nickname = nickname;
			CompletedLevelsCount = completedLevelsCount;
		}
	}
}
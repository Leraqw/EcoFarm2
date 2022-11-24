using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Player
	{
		public string Nickname { get; set; }
		public int CompletedLevelsCount { get; set; }
	}
}
using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Level
	{
		public int    Order           { get; set; }
		public int    TreesCount      { get; set; }
		public int    SecondsForLevel { get; set; }
		public Goal[] Goals           { get; set; }
	}
}
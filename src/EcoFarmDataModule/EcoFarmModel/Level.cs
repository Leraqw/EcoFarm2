using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Level
	{
		public int Order;
		public int TreesCount;
		public int SecondsForLevel;
		public Goal[] Goals;
	}
}
using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Generator : Building
	{
		public Resource Resource;
		public int EfficiencyCoefficient;
	}
}
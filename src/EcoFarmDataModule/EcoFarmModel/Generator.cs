using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Generator : Building
	{
		public Resource Resource              { get; set; }
		public int      EfficiencyCoefficient { get; set; }
	}
}
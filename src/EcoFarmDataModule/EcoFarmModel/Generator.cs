using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Generator : Building
	{
		public int EfficiencyCoefficient { get; set; }

		public Generator(string title, string description, int cost, int efficiencyCoefficient) 
			: base(title, description, cost)
			=> EfficiencyCoefficient = efficiencyCoefficient;
	}
}
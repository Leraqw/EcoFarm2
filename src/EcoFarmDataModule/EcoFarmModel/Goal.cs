using System;

namespace EcoFarmModel
{
	[Serializable]
	public abstract class Goal
	{
		public int TargetQuantity { get; set; }
	}
}
using System;

namespace EcoFarmModel
{
	[Serializable]
	public abstract class DevelopmentObject
	{
		public string Title       { get; set; }
		public string Description { get; set; }
		public int    Price       { get; set; }
	}
}
using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Tree : DevelopmentObject
	{
		public Product Product { get; set; }
	}
}
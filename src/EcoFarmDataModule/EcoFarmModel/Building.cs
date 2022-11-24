using System;
using EcoFarmDataModuleOld;

namespace EcoFarmModel
{
	[Serializable]
	public abstract class Building : DevelopmentObject
	{
		protected Building(string title, string description, int cost) : base(title, description, cost) { }
	}
}
using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Storage
	{
		public Resource[] Resources;
		public Product[] Products;
		public Level[] Levels;
		public Tree[] Trees;
		public Building[] Buildings;
	}
}
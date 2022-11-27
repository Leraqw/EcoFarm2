using System;

namespace EcoFarmModel
{
	[Serializable]
	public class Storage
	{
		public Resource[] Resources { get; set; }
		public Product[]  Products  { get; set; }
		public Level[]    Levels    { get; set; }
		public Tree[]     Trees     { get; set; }
		public Building[] Buildings { get; set; }
	}
}
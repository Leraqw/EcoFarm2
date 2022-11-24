using System;
using SQLite;

namespace EcoFarmDataModuleOld
{
	[Serializable]
	public abstract class DevelopmentObject
	{
		[PrimaryKey, AutoIncrement, Unique] public int    Id          { get; set; }
		public                                     string Title       { get; set; }
		public                                     string Description { get; set; }
		public                                     int    Price       { get; set; }

		public DevelopmentObject() { }

		protected DevelopmentObject(string title, string description, int price)
		{
			Title = title;
			Description = description;
			Price = price;
		}
	}
}
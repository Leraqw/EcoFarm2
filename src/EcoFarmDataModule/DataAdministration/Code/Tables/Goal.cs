using SQLite;

namespace DataAdministration.Tables
{
	public class Goal
	{
		[PrimaryKey, AutoIncrement] public int Id             { get; set; }
		public                             int LevelId        { get; set; }
		public                             int ObjectId       { get; set; }
		public                             int TargetQuantity { get; set; }
	}
}
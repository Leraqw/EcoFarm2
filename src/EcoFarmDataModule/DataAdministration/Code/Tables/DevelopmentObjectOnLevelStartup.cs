using SQLite;

namespace DataAdministration.Tables
{
	public class DevelopmentObjectOnLevelStartup
	{
		[PrimaryKey, AutoIncrement] public int Id                  { get; set; }
		public                             int DevelopmentObjectId { get; set; }
		public                             int LevelId             { get; set; }
		public                             int Quantity            { get; set; }
	}
}
using SQLite;

namespace DataAdministration.Tables
{
	public class DevelopmentObjectOnLevelStartup
	{
		[PrimaryKey] public int DevelopmentObjectId { get; set; }
		[PrimaryKey] public int LevelId             { get; set; }
		public              int Quantity            { get; set; }
	}
}
using SQLite;

namespace DataAdministration.Tables
{
	public class UserProgress
	{
		[PrimaryKey, AutoIncrement] public int Id      { get; set; }
		public                             int UserId  { get; set; }
		public                             int LevelId { get; set; }
	}
}
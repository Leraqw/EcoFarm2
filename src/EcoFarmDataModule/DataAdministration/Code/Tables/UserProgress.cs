using SQLite;

namespace DataAdministration.Tables
{
	public class UserProgress
	{
		[PrimaryKey] public int UserId  { get; set; }
		[PrimaryKey] public int LevelId { get; set; }
	}
}
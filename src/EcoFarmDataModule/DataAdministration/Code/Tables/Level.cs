using SQLite;

namespace DataAdministration.Tables
{
	public class Level
	{
		[PrimaryKey, AutoIncrement] public int Id    { get; set; }
		public                             int Order { get; set; }
	}
}
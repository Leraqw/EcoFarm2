using SQLite;

namespace DataAdministration.Tables
{
	public class User
	{
		[PrimaryKey, AutoIncrement] public int    Id       { get; set; }
		public                             string Nickname { get; set; }
	}
}
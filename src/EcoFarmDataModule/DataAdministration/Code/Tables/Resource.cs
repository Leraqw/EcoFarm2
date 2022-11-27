using SQLite;

namespace DataAdministration.Tables
{
	public class Resource
	{
		[PrimaryKey, AutoIncrement] public int Id { get; set; }
		public                             string   Title  { get; set; }
		public                             string   Description  { get; set; }
	}
}
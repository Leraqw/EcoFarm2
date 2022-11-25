using SQLite;

namespace DataAdministration.Tables
{
	public class DevelopmentObject
	{
		public DevelopmentObject() { }

		[PrimaryKey, AutoIncrement] public int    Id          { get; set; }
		public                             string Title       { get; set; }
		public                             string Description { get; set; }
		public                             int    Price       { get; set; }
	}
}
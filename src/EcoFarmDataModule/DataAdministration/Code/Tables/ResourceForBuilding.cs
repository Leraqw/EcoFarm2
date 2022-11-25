using SQLite;

namespace DataAdministration.Tables
{
	public class ResourceForBuilding
	{
		[PrimaryKey, AutoIncrement] public int Id         { get; set; }
		public                             int BuildingId { get; set; }
		public                             int ResourceId { get; set; }
		public                             int Quantity   { get; set; }
	}
}
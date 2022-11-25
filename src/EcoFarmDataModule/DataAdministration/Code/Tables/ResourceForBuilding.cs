using SQLite;

namespace DataAdministration.Tables
{
	public class ResourceForBuilding
	{
		[PrimaryKey] public int BuildingId { get; set; }
		[PrimaryKey] public int ResourceId { get; set; }
		public              int Quantity   { get; set; }
	}
}
using SQLite;

namespace DataAdministration.Tables
{
	public class OutputProducts
	{
		[PrimaryKey, AutoIncrement] public int Id         { get; set; }
		public                             int ProductId  { get; set; }
		public                             int BuildingId { get; set; }
		public                             int Quantity   { get; set; }
	}
}
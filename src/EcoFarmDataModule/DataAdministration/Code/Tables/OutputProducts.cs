using SQLite;

namespace DataAdministration.Tables
{
	public class OutputProducts
	{
		[PrimaryKey] public int ProductId  { get; set; }
		[PrimaryKey] public int BuildingId { get; set; }
		public              int Quantity   { get; set; }
	}
}
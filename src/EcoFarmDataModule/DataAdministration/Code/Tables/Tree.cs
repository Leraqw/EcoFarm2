using SQLite;

namespace DataAdministration.Tables
{
	public class Tree
	{
		[PrimaryKey] public int Id        { get; set; }
		public              int ProductId { get; set; }
	}
}
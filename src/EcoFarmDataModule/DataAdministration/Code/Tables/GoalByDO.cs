using SQLite;

namespace DataAdministration.Tables
{
	public class GoalByDo
	{
		[PrimaryKey] public int Id                  { get; set; }
		public              int DevelopmentObjectId { get; set; }
	}
}
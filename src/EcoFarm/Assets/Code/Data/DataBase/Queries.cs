namespace Code.Data.DataBase
{
	public static class Queries
	{
		public static string CreateTableTree
			=> "CREATE TABLE IF NOT EXISTS Tree "
			   + "(TreeID INTEGER NOT NULL, "
			   + "PRIMARY KEY(TreeID AUTOINCREMENT));";
	}
}
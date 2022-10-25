namespace Code.Data.DataBase
{
	public static class Queries
	{
		public static string CreateTableTree
			=> "CREATE TABLE IF NOT EXISTS Tree "
			   + "(TreeID INTEGER NOT NULL, "
			   + "PRIMARY KEY(TreeID AUTOINCREMENT));";
		
		public static string CreateTableLevel
			=> "CREATE TABLE IF NOT EXISTS Level "
			   + "(LevelID INTEGER NOT NULL, "
			   + "PRIMARY KEY(TreeID AUTOINCREMENT));";
		
	}
}
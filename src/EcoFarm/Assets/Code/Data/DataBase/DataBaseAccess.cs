using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public class DataBaseAccess
	{
		private const string DataBaseName = "URI=file:EcoFarm.db";

		public void CreateDataBase()
		{
			using var connection = new SqliteConnection(DataBaseName);
			connection.Open();

			using var command = connection.CreateCommand();

			command.ExecuteNonQuery(CreateTableTree());
		}

		private static string CreateTableTree()
			=> "CREATE TABLE IF NOT EXISTS Tree "
			   + "(TreeID INTEGER NOT NULL, "
			   + "PRIMARY KEY(TreeID AUTOINCREMENT));";
	}

	public static class SqliteCommandExtensions
	{
		public static void ExecuteNonQuery(this SqliteCommand command, string query)
		{
			command.CommandText = query;
			command.ExecuteNonQuery();
		}
	}
}
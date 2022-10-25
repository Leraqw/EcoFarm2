using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public static class SqliteCommandExtensions
	{
		public static void ExecuteNonQuery(this SqliteCommand command, string query)
		{
			command.CommandText = query;
			command.ExecuteNonQuery();
		}
	}
}
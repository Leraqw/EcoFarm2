using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public static class SqliteCommandExtensions
	{
		public static SqliteCommand CreateCommand(this SqliteConnection @this, string query)
		{
			var command = @this.CreateCommand();
			command.CommandText = query;
			return command;
		}

		public static T ReadFirst<T>(this SqliteDataReader @this)
		{
			@this.Read();
			return @this.GetFieldValue<T>(0);
		}
	}
}
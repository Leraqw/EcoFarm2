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
			command.ExecuteNonQuery(Queries.CreateTableTree);
		}
	}
}
using System;
using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public class DataBaseAccess
	{
		private const string DataBaseName = "URI=file:EcoFarm.db";

		public int TreesCount => GetInt(Queries.SelectTreesQuantity);

		public void DisplayData() => throw new NotImplementedException();

		private static int GetInt(string query)
		{
			using var connection = new SqliteConnection(DataBaseName);
			connection.Open();
			using var command = connection.CreateCommand();

			command.CommandText = query;
			var reader = command.ExecuteReader();
			reader.Read();
			return reader.GetInt32(0);
		}
	}
}
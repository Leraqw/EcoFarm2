using System;
using Code.Utils.Extensions.DataBase;
using Mono.Data.Sqlite;

namespace Code.Data.DataBase
{
	public class DataBaseAccess : IDisposable, IDataAccess
	{
		private readonly SqliteConnection _connection;

		public DataBaseAccess()
		{
			_connection = new SqliteConnection(DataBaseName);
			_connection.Open();
		}

		public void Dispose() => _connection.Close();

		private const string DataBaseName = "URI=file:EcoFarm.db";

		public int TreesCount => GetInt(Queries.SelectTreesQuantity);

		private int GetInt(string query)
		{
			using var command = _connection.CreateCommand(query);
			using var reader = command.ExecuteReader();

			return (int)reader.ReadFirst<long>();
		}
	}
}
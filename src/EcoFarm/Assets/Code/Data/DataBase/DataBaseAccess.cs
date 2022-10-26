using Mono.Data.Sqlite;
using UnityEngine;

namespace Code.Data.DataBase
{
	public class DataBaseAccess
	{
		private const string DataBaseName = "URI=file:EcoFarm.db";
		public int TreesCount => GetTreesCount();

		public void DisplayData()
		{
			using var connection = new SqliteConnection(DataBaseName);
			connection.Open();
			using var command = connection.CreateCommand();

			Debug.Log("Ur mama");
		}

		private int GetTreesCount()
		{
			using var connection = new SqliteConnection(DataBaseName);
			connection.Open();
			using var command = connection.CreateCommand();

			command.CommandText = Queries.SelectTreesQuantity;
			var reader = command.ExecuteReader();
			reader.Read();
			return reader.GetInt32(0);
		}
	}
}
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine;

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

		// ReSharper disable Unity.PerformanceAnalysis
		public void DisplayData()
		{
			using var connection = new SqliteConnection(DataBaseName);
			connection.Open();
			using var command = connection.CreateCommand();

			PrintAllValuesFrom(command, "Tree");
			PrintAllValuesFrom(command, "Level");
			PrintAllValuesFrom(command, "TreesOnLevel");
		}

		private static void PrintAllValuesFrom(SqliteCommand command, string table)
		{
			Debug.Log($"——{table}——");
			command.CommandText = $"SELECT * FROM {table};";

			var reader = command.ExecuteReader();
			var columns = reader.FieldCount;
			
			LogNames(reader, columns);
			reader.Close();
			
			reader = command.ExecuteReader();
			
			LogValues(reader, columns);
			reader.Close();
			
			Debug.Log("———————————");
		}

		private static void LogNames(SqliteDataReader reader, int columnsCount)
		{
			while (reader.Read())
			{
				var value = string.Empty;

				for (var i = 0; i < columnsCount; i++)
				{
					value += $"| {reader.GetName(i)} |";
				}

				Debug.Log(value);
			}

		}

		private static void LogValues(IDataReader reader,  int columnsCount)
		{
			while (reader.Read())
			{
				var value = string.Empty;

				for (var i = 0; i < columnsCount; i++)
				{
					value += $"| {reader.GetValue(i)} |";
				}

				Debug.Log(value);
			}
		}
	}
}
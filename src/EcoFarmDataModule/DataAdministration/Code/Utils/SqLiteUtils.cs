using System;
using System.Collections.Generic;
using SQLite;

namespace DataAdministration
{
	public static class SqLiteUtils
	{
		public static string CurrentPath { get; set; }

		public static void Perform(Action<SQLiteConnection> @do)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				@do.Invoke(dataBase);
			}
		}

		public static TOut Select<TOut>(Func<SQLiteConnection, TOut> @do)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				return @do.Invoke(dataBase);
			}
		}

		public static List<object> Select(Type type)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				return dataBase.Query(new TableMapping(type), $"SELECT * FROM {type.Name}");
			}
		}
		
		public static void Update(object item)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				dataBase.Update(item);
				dataBase.Commit();
			}
		}
		
		public static void Insert(object item)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				dataBase.Insert(item);
				dataBase.Commit();
			}
		}
		
		public static void Delete(object item)
		{
			using (var dataBase = new SQLiteConnection(CurrentPath))
			{
				dataBase.Delete(item);
				dataBase.Commit();
			}
		}
	}
}
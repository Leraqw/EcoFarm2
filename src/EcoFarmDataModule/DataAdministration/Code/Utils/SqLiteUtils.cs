using System;
using System.Collections.Generic;
using SQLite;

namespace DataAdministration
{
	public static class SqLiteUtils
	{
		private static readonly List<Type> TypesForTables = new List<Type>();

		public static SQLiteConnection At(string path) => new SQLiteConnection(path);

		public static void Perform(Action<SQLiteConnection> @do)
		{
			using (var dataBase = new SQLiteConnection(Constants.DbPath))
			{
				@do.Invoke(dataBase);
			}
		}

		public static void Perform(this SQLiteConnection @this, Action<SQLiteConnection> @do)
		{
			using (@this)
			{
				@do.Invoke(@this);
			}
		}

		public static SQLiteConnection StartConnection() => StartConnection(Constants.DbPath);

		public static SQLiteConnection StartConnection(string path) => new SQLiteConnection(path);

		public static SQLiteConnection Add<T>(this SQLiteConnection @this)
		{
			TypesForTables.Add(typeof(T));
			return @this;
		}

		public static void Build(this SQLiteConnection @this)
		{
			TypesForTables.ForEach((t) => @this.CreateTable(t));
			TypesForTables.Clear();

			@this.Close();
		}
	}
}
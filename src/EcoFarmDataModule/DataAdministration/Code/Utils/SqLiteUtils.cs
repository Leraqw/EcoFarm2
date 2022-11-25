using System;
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
	}
}
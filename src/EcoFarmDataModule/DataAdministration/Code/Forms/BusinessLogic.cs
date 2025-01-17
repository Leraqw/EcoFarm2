﻿// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
using System.ComponentModel;
using System.IO;
using SQLite;

namespace DataAdministration
{
	public class BusinessLogic
	{
		public bool TryCreateDataBase()
		{
			if (FileUtils.TrySelectFolder(out var path) == false)
			{
				return false;
			}

			path = Path.Combine(path, "EcoFarm.db");
			SqLiteUtils.CurrentPath = path;

			SqLiteUtils.Perform(CreateAllTables);

			return true;
		}

		public bool TryOpenDataBase()
		{
			if (FileUtils.TryOpenDb(out var path) == false)
			{
				return false;
			}

			SqLiteUtils.CurrentPath = path;
			return true;
		}

		public BindingList<T> GetTableData<T>()
			where T : new()
			=> SqLiteUtils.Select((c) => new BindingList<T>(c.Table<T>().ToList()));

		public void InsertOrReplace(object item) => SqLiteUtils.Perform((c) => c.InsertOrReplace(item));

		public void Delete(object item)
		{
			SqLiteUtils.Perform((c) => c.Delete(item));
		}

		private void CreateAllTables(SQLiteConnection connection)
		{
			foreach (var type in TablesCollection.Types)
			{
				connection.CreateTable(type);
			}
		}
	}
}
// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using SQLite;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace DataAdministration
{
	public class BusinessLogic
	{
		public void CreateDataBase()
		{
			SqLiteUtils.CurrentPath = GetPath();
			SqLiteUtils.Perform(Create);

			MessageBox.Show("База Данных создана", "Успех", OK, Information);
		}

		private void Create(SQLiteConnection connection)
		{
			foreach (var type in TablesCollection.Types)
			{
				connection.CreateTable(type);
			}
		}

		private static string GetPath()
		{
			var pathToDirectory = new FolderBrowserDialog().GetSelectedPath();
			return Path.Combine(pathToDirectory, "EcoFarm.db");
		}

		public BindingList<T> GetTableData<T>()
			where T : new()
			=> SqLiteUtils.Select((c) => new BindingList<T>(c.Table<T>().ToList()));
	}
}
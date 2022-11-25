// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
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
		public bool TryCreateDataBase()
		{
			if (FileUtils.TrySelectFolder(out var path) == false)
			{
				return false;
			}

			path = Path.Combine(path, "EcoFarm.db");
			SqLiteUtils.CurrentPath = path;

			SqLiteUtils.Perform(CreateAllTables);

			MessageBox.Show("База Данных создана", "Успех", OK, Information);
			return true;
		}

		public void OpenDataBase()
		{
			SqLiteUtils.CurrentPath = GetFilePath();

			MessageBox.Show("База Данных открыта", "Успех", OK, Information);
		}

		public BindingList<T> GetTableData<T>()
			where T : new()
			=> SqLiteUtils.Select((c) => new BindingList<T>(c.Table<T>().ToList()));

		private static string GetFilePath()
		{
			var pathToDirectory = FileUtils.OpenDb();
			return Path.Combine(pathToDirectory);
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
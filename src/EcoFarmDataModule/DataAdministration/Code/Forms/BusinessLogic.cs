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
		public void CreateDataBase()
		{
			SqLiteUtils.CurrentPath = GetDirectoryPath();
			SqLiteUtils.Perform(Create);

			MessageBox.Show("База Данных создана", "Успех", OK, Information);
		}

		private static string GetDirectoryPath()
		{
			var pathToDirectory = FileUtils.GetSelectedPath();
			return Path.Combine(pathToDirectory, "EcoFarm.db");
		}

		private static string GetFilePath()
		{
			var pathToDirectory = FileUtils.OpenDb();
			return Path.Combine(pathToDirectory);
		}

		public BindingList<T> GetTableData<T>()
			where T : new()
			=> SqLiteUtils.Select((c) => new BindingList<T>(c.Table<T>().ToList()));

		public void OpenDataBase()
		{
			SqLiteUtils.CurrentPath = GetFilePath();

			MessageBox.Show("База Данных открыта", "Успех", OK, Information);
		}

		private void Create(SQLiteConnection connection)
		{
			foreach (var type in TablesCollection.Types)
			{
				connection.CreateTable(type);
			}
		}
	}
}
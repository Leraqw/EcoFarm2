// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
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
			var path = GetPath();

			SqLiteUtils.At(path).Perform(Create);

			MessageBox.Show("База Данных создана", "Успех", OK, Information);
		}

		private void Create(SQLiteConnection connection)
		{
			var tables = new TablesCollection();

			foreach (var type in tables.Types)
			{
				connection.CreateTable(type);
			}
		}

		private static string GetPath()
		{
			var pathToDirectory = new FolderBrowserDialog().GetSelectedPath();
			return Path.Combine(pathToDirectory, "EcoFarm.db");
		}
	}
}
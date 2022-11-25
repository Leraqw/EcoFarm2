// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo
using System.IO;
using System.Windows.Forms;
using EcoFarmModel;
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

		public object GetTable(string tableName)
		{
			using (var connection = new SQLiteConnection(SqLiteUtils.CurrentPath))
			{
				return connection.Table<Product>();
			}
		}

		public TableQuery<T> GetTableData<T>()
			where T : new()
		{
			using (var connection = new SQLiteConnection(SqLiteUtils.CurrentPath))
			{
				return connection.Table<T>();
			}
		}
	}
}
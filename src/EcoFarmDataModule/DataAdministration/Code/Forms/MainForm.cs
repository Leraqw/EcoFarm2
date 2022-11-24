using System;
using System.IO;
using System.Windows.Forms;
using SQLite;
using Level = DataAdministration.Tables.Level;

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		public MainForm() => InitializeComponent();

		private static string DbPath => Path.Combine(Directory.GetCurrentDirectory(), "EcoFarm.db");

		private void MainForm_Load(object sender, EventArgs e) => CreateDbIfIsNotExists();

		private void CreateDbIfIsNotExists()
		{
			if (File.Exists(DbPath))
			{
				// return;
			}

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.CreateTable<Level>();
			}
		}

		private void ButtonTest_Click(object sender, EventArgs e)
		{
			var newObject = new Level
			{
				Order = 1,
			};
			
			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.Insert<Level>(newObject);
			}
		}
	}
}
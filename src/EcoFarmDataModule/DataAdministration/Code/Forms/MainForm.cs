using System;
using System.IO;
using System.Windows.Forms;
using DataAdministration.Tables;
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
			if (File.Exists(DbPath)) { }

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.CreateTable<DevelopmentObject>();
				dataBase.CreateTable<Level>();
				dataBase.CreateTable<DevelopmentObjectOnLevelStartup>();
			}
		}

		private void ButtonTest_Click(object sender, EventArgs e)
		{
			var developmentObject = new DevelopmentObject()
			{
				Title = "Some",
			};

			var level = new Level
			{
				Order = 1,
			};

			var relation = new DevelopmentObjectOnLevelStartup
			{
				DevelopmentObjectId = 1,
				LevelId = 12,
				Quantity = 5,
			};

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.Insert<DevelopmentObject>(developmentObject);
				dataBase.Insert<Level>(level);
				dataBase.Insert<DevelopmentObjectOnLevelStartup>(relation);
			}
		}
	}
}
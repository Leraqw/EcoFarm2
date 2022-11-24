using System;
using System.IO;
using System.Windows.Forms;
using EcoFarmModel;
using SQLite;

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
				return;
			}

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.CreateTable<DevelopmentObject>();
			}
		}

		private void ButtonTest_Click(object sender, EventArgs e)
		{
			var newObject = new Generator()
			{
				Title = "Not Generator",
				Description = "asd",
				EfficiencyCoefficient = 25,
				Price = 12,
			};
			
			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.Insert<DevelopmentObject>(newObject);
			}
		}
	}
}
using System;
using System.IO;
using System.Windows.Forms;
using DataAdministration.Tables;
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
			if (File.Exists(DbPath)) { }

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.CreateTable<Product>();
			}
		}

		private void ButtonTest_Click(object sender, EventArgs e)
		{
			var product = new Product
			{
				Title = "Apple",
				Description = "Red apple",
				Price = 2,
			};

			using (var dataBase = new SQLiteConnection(DbPath))
			{
				dataBase.Insert(product);
			}
		}
	}
}
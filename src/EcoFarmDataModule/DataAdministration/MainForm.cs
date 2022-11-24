using System;
using System.IO;
using System.Windows.Forms;
using SQLite;

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		public MainForm() => InitializeComponent();

		private static string Path => System.IO.Path.Combine(Directory.GetCurrentDirectory(), @"\EcoFarm.db");

		private void MainForm_Load(object sender, EventArgs e) => CreateDbIfIsNotExists();

		private void CreateDbIfIsNotExists()
		{
			if (File.Exists(Path))
			{
				return;
			}

			using (var dataBase = new SQLiteConnection(Path))
			{
				// dataBase.CreateTable<DevelopmentObject>();
			}
		}

		private void ButtonTest_Click(object sender, EventArgs e)
		{
			
		}
	}
}
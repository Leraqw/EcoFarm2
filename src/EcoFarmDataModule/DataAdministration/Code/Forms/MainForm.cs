﻿// ReSharper disable LocalizableElement
using System;
using System.IO;
using System.Windows.Forms;
using DataAdministration.Tables;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		public MainForm() => InitializeComponent();

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e) => CreateDataBase();

		private static void CreateDataBase()
		{
			var pathToDirectory = new FolderBrowserDialog().GetSelectedPath();
			var completePath = Path.Combine(pathToDirectory, "EcoFarm.db");

			Create(at: completePath);

			MessageBox.Show("БД создана!", "Успех", OK, Information);
		}

		private static void Create(string at)
		{
			SqLiteUtils
				.StartConnection(at)
				.Add<Building>()
				.Add<DevelopmentObject>()
				.Add<DevelopmentObjectOnLevelStartup>()
				.Add<Factory>()
				.Add<Generator>()
				.Add<Goal>()
				.Add<InputProducts>()
				.Add<Level>()
				.Add<OutputProducts>()
				.Add<Product>()
				.Add<Resource>()
				.Add<ResourceForBuilding>()
				.Add<Tree>()
				.Add<User>()
				.Add<UserProgress>()
				.Build()
				;
		}
	}
}
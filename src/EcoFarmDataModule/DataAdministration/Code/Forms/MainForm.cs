using System;
using System.ComponentModel;
using System.Windows.Forms;
using DataAdministration.Tables;
using Building = DataAdministration.Tables.Building;
using DevelopmentObject = DataAdministration.Tables.DevelopmentObject;
using Generator = DataAdministration.Tables.Generator;
using Goal = DataAdministration.Tables.Goal;
using Level = DataAdministration.Tables.Level;
using Product = DataAdministration.Tables.Product;
using Resource = DataAdministration.Tables.Resource;
using Tree = DataAdministration.Tables.Tree;

// ReSharper disable StringLiteralTypo

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		private readonly BusinessLogic _businessLogic;

		public MainForm()
		{
			InitializeComponent();

			_businessLogic = new BusinessLogic();
			_businessLogic.NotifyTableChanged += (sender, args) => UpdateTables();
		}

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e)
		{
			if (_businessLogic.TryCreateDataBase())
			{
				UpdateTables();
				MessageUtils.ShowSuccess("База Данных создана");
			}
		}

		private void ButtonOpenDb_Click(object sender, EventArgs e)
		{
			if (_businessLogic.TryOpenDataBase())
			{
				UpdateTables();
				MessageUtils.ShowSuccess("База Данных открыта");
			}
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			Save<Product>();
			Save<Level>();
			Save<DevelopmentObject>();
			Save<Tree>();
			Save<Building>();
			Save<Factory>();
			Save<Generator>();
			Save<Resource>();
			Save<Goal>();
			Save<DevelopmentObjectOnLevelStartup>();
			Save<InputProducts>();

			MessageUtils.ShowSuccess("Данные сохранены");
		}

		private void Save<T>()
		{
			var items = (BindingList<T>)ProductsData.DataSource;
			foreach (var item in items)
			{
				_businessLogic.Save(item);
			}
		}

		private void UpdateTables()
		{
			ProductsData.DataSource = _businessLogic.GetTableData<Product>();
			LevelsData.DataSource = _businessLogic.GetTableData<Level>();
			DOData.DataSource = _businessLogic.GetTableData<DevelopmentObject>();
			TreesData.DataSource = _businessLogic.GetTableData<Tree>();
			BuildingsData.DataSource = _businessLogic.GetTableData<Building>();
			FactoriesData.DataSource = _businessLogic.GetTableData<Factory>();
			GeneratorsData.DataSource = _businessLogic.GetTableData<Generator>();
			ResourcesData.DataSource = _businessLogic.GetTableData<Resource>();
			GoalsData.DataSource = _businessLogic.GetTableData<Goal>();
			DOonLevelsData.DataSource = _businessLogic.GetTableData<DevelopmentObjectOnLevelStartup>();
			InputProductsData.DataSource = _businessLogic.GetTableData<InputProducts>();
			OutputProductsData.DataSource = _businessLogic.GetTableData<OutputProducts>();
			ResourcesForFactoryData.DataSource = _businessLogic.GetTableData<ResourceForBuilding>();
		}
	}
}
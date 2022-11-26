using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DataAdministration.Tables;
using EcoFarmModel;
using Newtonsoft.Json;
using Building = DataAdministration.Tables.Building;
using DevelopmentObject = DataAdministration.Tables.DevelopmentObject;
using Generator = DataAdministration.Tables.Generator;
using Goal = DataAdministration.Tables.Goal;
using Level = DataAdministration.Tables.Level;
using Product = DataAdministration.Tables.Product;
using Resource = DataAdministration.Tables.Resource;
using Tree = DataAdministration.Tables.Tree;
// ReSharper disable LocalizableElement

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
		}

		private static JsonSerializerSettings JsonSettings
			=> new JsonSerializerSettings
			{
				PreserveReferencesHandling = PreserveReferencesHandling.Objects,
				TypeNameHandling = TypeNameHandling.All,
			};

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
			Save<Product>(ProductsData);
			Save<Level>(LevelsData);
			Save<DevelopmentObject>(DOData);
			Save<Tree>(TreesData);
			Save<Building>(BuildingsData);
			Save<Factory>(FactoriesData);
			Save<Generator>(GeneratorsData);
			Save<Resource>(ResourcesData);
			Save<Goal>(GoalsData);
			Save<DevelopmentObjectOnLevelStartup>(DOonLevelsData);
			Save<InputProducts>(InputProductsData);
			Save<OutputProducts>(OutputProductsData);
			Save<ResourceForBuilding>(ResourcesForFactoryData);

			MessageUtils.ShowSuccess("Данные сохранены");
		}

		private void ButtonDelete_Click(object sender, EventArgs e)
		{
			var deletedCount = 0;

			deletedCount += Delete<Product>(ref ProductsData);
			deletedCount += Delete<Level>(ref LevelsData);
			deletedCount += Delete<DevelopmentObject>(ref DOData);
			deletedCount += Delete<Tree>(ref TreesData);
			deletedCount += Delete<Building>(ref BuildingsData);
			deletedCount += Delete<Factory>(ref FactoriesData);
			deletedCount += Delete<Generator>(ref GeneratorsData);
			deletedCount += Delete<Resource>(ref ResourcesData);
			deletedCount += Delete<Goal>(ref GoalsData);
			deletedCount += Delete<DevelopmentObjectOnLevelStartup>(ref DOonLevelsData);
			deletedCount += Delete<InputProducts>(ref InputProductsData);
			deletedCount += Delete<OutputProducts>(ref OutputProductsData);
			deletedCount += Delete<ResourceForBuilding>(ref ResourcesForFactoryData);

			if (deletedCount > 0)
			{
				MessageUtils.ShowSuccess($"Удалено {deletedCount} записей");
			}
			else
			{
				MessageUtils.ShowWarning("Для удаления выделите одну или несколько строк");
			}
		}

		private void Save<T>(DataGridView grid)
		{
			var items = (BindingList<T>)grid.DataSource;
			foreach (var item in items)
			{
				_businessLogic.InsertOrReplace(item);
			}
		}

		private void ButtonDeserialize_Click(object sender, EventArgs e)
		{
			var dialog = new OpenFileDialog
			{
				Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
				FilterIndex = 1,
				RestoreDirectory = true,
			};

			if (dialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}

			var path = dialog.FileName;
			var data = File.ReadAllText(path);
			var storage = JsonConvert.DeserializeObject<Storage>(data, JsonSettings);

			storage.ToTables().ForEach(_businessLogic.InsertOrReplace);

			UpdateTables();
			MessageUtils.ShowSuccess("Данные загружены");
		}

		private int Delete<T>(ref DataGridView grid)
		{
			var deletedCount = 0;
			var rows = grid.SelectedRows;
			foreach (DataGridViewRow row in rows)
			{
				var item = (T)row.DataBoundItem;
				_businessLogic.Delete(item);
				deletedCount++;
			}

			foreach (DataGridViewRow row in rows)
			{
				grid.Rows.Remove(row);
			}

			grid.Refresh();
			return deletedCount;
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
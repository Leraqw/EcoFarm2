using System;
using System.Windows.Forms;
using DataAdministration.Tables;
using Product = DataAdministration.Tables.Product;

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

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e)
		{
			if (_businessLogic.TryCreateDataBase())
			{
				UpdateTables();
			}
		}

		private void ButtonOpenDb_Click(object sender, EventArgs e)
		{
			if (_businessLogic.TryOpenDataBase())
			{
				UpdateTables();
			}
		}

		private void UpdateTables()
		{
			ProductsData.DataSource = _businessLogic.GetTableData<Product>();
			LevelsData.DataSource = _businessLogic.GetTableData<Level>();
		}
	}
}
using System;
using System.Windows.Forms;
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
			_businessLogic.OpenDataBase();

			UpdateTables();
		}

		private void UpdateTables()
		{
			ProductsData.DataSource = _businessLogic.GetTableData<Product>();
		}
	}
}
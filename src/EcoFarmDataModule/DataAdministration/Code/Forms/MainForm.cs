using System;
using System.Linq;
using System.Windows.Forms;
using DataAdministration.Tables;

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		private readonly BusinessLogic _businessLogic;
		
		public MainForm()
		{
			InitializeComponent();

			_businessLogic = new BusinessLogic();
			CurrentTableComboBox.DataSource = TablesCollection.Types.Select((t) => t.Name).ToList();
		}

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e)
		{
			_businessLogic.CreateDataBase();
		}

		private void CurrentTableComboBox_SelectedValueChanged(object sender, EventArgs e)
		{
			// Update value in dataGridView
			var selectedTable = CurrentTableComboBox.SelectedItem.ToString();
			var type = TablesCollection.Types.First((t) => t.Name == selectedTable);

			if (type.Name == nameof(Product))
			{
				MainDataGridView.DataSource = _businessLogic.GetTableData<Product>();
			}
		}
	}
}
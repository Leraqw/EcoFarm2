using System;
using System.Linq;
using System.Windows.Forms;

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
			// MainDataGridView.DataSource = _businessLogic.GetTable();
		}
	}
}
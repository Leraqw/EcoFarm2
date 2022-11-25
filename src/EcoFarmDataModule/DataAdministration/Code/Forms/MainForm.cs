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
		}

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e)
		{
			_businessLogic.CreateDataBase();
		}
	}
}
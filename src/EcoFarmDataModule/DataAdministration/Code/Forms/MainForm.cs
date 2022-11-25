using System;
using System.Windows.Forms;
using DataAdministration.Tables;

namespace DataAdministration
{
	public partial class MainForm : Form
	{
		public MainForm() => InitializeComponent();

		private void MainForm_Load(object sender, EventArgs e) { }

		private void ButtonNewDb_Click(object sender, EventArgs e) => CreateDataBase();

		private static void CreateDataBase()
		{
			SqLiteUtils
				.StartConnection()
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
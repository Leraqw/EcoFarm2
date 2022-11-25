// ReSharper disable LocalizableElement
using System.IO;
using System.Windows.Forms;

namespace DataAdministration
{
	public class BusinessLogic
	{
		public void CreateDataBase()
		{
			var completePath = GetPath();

			SqLiteUtils.CreateDataBase(at: completePath);

			MessageBox.Show("БД создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private static string GetPath()
		{
			var pathToDirectory = new FolderBrowserDialog().GetSelectedPath();
			var completePath = Path.Combine(pathToDirectory, "EcoFarm.db");
			return completePath;
		}
	}
}
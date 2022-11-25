using System.Windows.Forms;

namespace DataAdministration
{
	public static class FileUtils
	{
		public static string GetSelectedPath()
		{
			var folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.ShowDialog();
			return folderBrowserDialog.SelectedPath;
		}
		
		public static string OpenDb()
		{
			// Filters for only *.db files
			var openFileDialog = new OpenFileDialog {Filter = "Database Files (*.db)|*.db"};
			openFileDialog.ShowDialog();
			return openFileDialog.FileName;
		}
	}
}
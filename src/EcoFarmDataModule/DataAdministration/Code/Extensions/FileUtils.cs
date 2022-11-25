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
			var openFileDialog = new OpenFileDialog { Filter = "Database Files (*.db)|*.db" };
			openFileDialog.ShowDialog();
			return openFileDialog.FileName;
		}
		
		public static bool TrySelectFolder(out string path)
		{
			var folderBrowserDialog = new FolderBrowserDialog();
			var result = folderBrowserDialog.ShowDialog();
			path = folderBrowserDialog.SelectedPath;
			return result == DialogResult.OK;
		}
	}
}
using System.Windows.Forms;
// ReSharper disable LocalizableElement

namespace DataAdministration
{
	public static class FileUtils
	{
		public static bool TryOpenDb(out string fileName)
		{
			var openFileDialog = new OpenFileDialog { Filter = "Database Files (*.db)|*.db" };
			var result = openFileDialog.ShowDialog();
			fileName = openFileDialog.FileName;
			return result is DialogResult.OK;
		}
		
		public static bool TrySelectFolder(out string path)
		{
			var folderBrowserDialog = new FolderBrowserDialog();
			var result = folderBrowserDialog.ShowDialog();
			path = folderBrowserDialog.SelectedPath;
			return result is DialogResult.OK;
		}
	}
}
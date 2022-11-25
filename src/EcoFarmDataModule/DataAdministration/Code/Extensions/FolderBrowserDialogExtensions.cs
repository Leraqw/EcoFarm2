using System.Windows.Forms;

namespace DataAdministration
{
	public static class FolderBrowserDialogExtensions
	{
		public static string GetSelectedPath(this FolderBrowserDialog @this)
		{
			@this.ShowDialog();
			return @this.SelectedPath;
		}
	}
}
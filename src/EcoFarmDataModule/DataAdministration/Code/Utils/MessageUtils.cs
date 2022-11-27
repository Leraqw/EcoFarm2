using System.Windows.Forms;
using static System.Windows.Forms.MessageBoxButtons;
using static System.Windows.Forms.MessageBoxIcon;

// ReSharper disable LocalizableElement
// ReSharper disable StringLiteralTypo

namespace DataAdministration
{
	public static class MessageUtils
	{
		public static void ShowSuccess(string message) => MessageBox.Show(message, "Успех", OK, Information);

		public static void ShowWarning(string message) => MessageBox.Show(message, "Предупреждение", OK, Warning);

		public static void ShowError(string message) => MessageBox.Show(message, "Ошибка", OK, Error);
	}
}
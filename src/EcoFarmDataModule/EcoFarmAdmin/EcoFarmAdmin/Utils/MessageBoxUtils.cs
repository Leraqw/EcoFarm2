using System.Windows;

namespace EcoFarmAdmin.Utils;

public static class MessageBoxUtils
{
	public static MessageBoxResult SaveChangesDialog()
	{
		return MessageBox.Show
		(
			"Данные не были сохранены. Сохранить?",
			"Внимание",
			MessageBoxButton.YesNoCancel,
			MessageBoxImage.Warning
		);
	}
}
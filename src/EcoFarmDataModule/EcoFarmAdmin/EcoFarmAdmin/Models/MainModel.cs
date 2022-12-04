using System.Windows;
using EcoFarmAdmin.ViewModels;

namespace EcoFarmAdmin.Models;

public class MainModel
{
	public void CreateNewDatabase()
	{
		var dialog = WindowsTransfer.SaveDataBaseDialog();
		if (dialog.ShowDialog() == false)
		{
			return;
		}

		DataBaseConnection.CreateDataBase(dialog.FileName);
	}

	public void OpenDatabase()
	{
		var dialog = WindowsTransfer.OpenDataBaseDialog();
		if (dialog.ShowDialog() == false)
		{
			return;
		}

		DataBaseConnection.OpenDataBase(dialog.FileName);
	}
}
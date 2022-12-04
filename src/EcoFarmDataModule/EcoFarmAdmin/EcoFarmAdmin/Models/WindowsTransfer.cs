using System.IO;
using EcoFarmAdmin.Domain;
using EcoFarmAdmin.EditWindows;
using Microsoft.Win32;

namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToDevObjectWindow() => new DevObjectEditor().Show();

	public static bool CreateProduct(out DevObject devObject)
	{
		devObject = new DevObject();
		return EditProduct(ref devObject);
	}

	public static bool EditProduct(ref DevObject devObject)
	{
		var window = new ProductEditWindow();
		var context = (ProductEditViewModel)window.DataContext;
		context.DevObject = devObject.Clone();
		window.ShowDialog();
		var confirmed = window.DialogResult ?? false;
		if (confirmed)
		{
			devObject.SetFrom(context.DevObject);
		}

		return confirmed;
	}

	public static SaveFileDialog SaveDataBaseDialog()
		=> new()
		{
			Filter = "SQLite database (*.db)|*.db",
			Title = "Select database file",
			FileName = "EcoFarm.db",
			InitialDirectory = Directory.GetCurrentDirectory(),
			OverwritePrompt = true,
			ValidateNames = true,
		};

	public static OpenFileDialog OpenDataBaseDialog()
		=> new()
		{
			Filter = "SQLite database (*.db)|*.db",
			Title = "Select database file",
			InitialDirectory = Directory.GetCurrentDirectory(),
			ValidateNames = true,
		};
}
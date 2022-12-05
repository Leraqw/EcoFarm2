using System.IO;
using EcoFarmAdmin.Domain;
using EcoFarmAdmin.EditWindows;
using Microsoft.Win32;

namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToDevObjectWindow() => new DevObjectEditor().Show();

	public static bool CreateProduct(out DevObject devObject) => EditProduct(new DevObject(), out devObject);

	public static bool EditProduct(in DevObject devObject, out DevObject changed)
	{
		var window = new ProductEditWindow();
		var context = (ProductEditViewModel)window.DataContext;

		context.DevObject = devObject.Clone();
		window.ShowDialog();

		changed = context.DevObject;
		return window.DialogResult ?? false;
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
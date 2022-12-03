using System.IO;
using Microsoft.Win32;

namespace EcoFarmAdmin.ViewModels;

public static class WindowsTransfer
{
	public static void ToDevObjectWindow() => new DevObjectEditor().Show();

	public static OpenFileDialog OpenDataBaseDialog()
		=> new()
		{
			Filter = "SQLite database (*.db)|*.db",
			Title = "Select database file",
			InitialDirectory = Directory.GetCurrentDirectory(),
			ValidateNames = true,
		};

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
}
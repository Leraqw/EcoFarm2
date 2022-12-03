using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace EcoFarmAdmin.Models;

public class MainModel
{
	private ApplicationContext? _dataBase;
	
	public bool IsDbConnected => _dataBase != null;

	public void CreateNewDatabase()
	{
		var dialog = new SaveFileDialog
		{
			Filter = "SQLite database (*.db)|*.db",
			Title = "Select database file",
			FileName = "EcoFarm.db",
			InitialDirectory = Directory.GetCurrentDirectory(),
			OverwritePrompt = true,
			ValidateNames = true,
		};
		if (dialog.ShowDialog() != true)
		{
			return;
		}

		var path = dialog.FileName;

		MessageBox.Show(path);
		_dataBase = new ApplicationContext(path);
		_dataBase.Database.EnsureCreated();
	}

	public void OpenDatabase()
	{
		var dialog = new OpenFileDialog
		{
			Filter = "SQLite database (*.db)|*.db",
			Title = "Select database file",
			InitialDirectory = Directory.GetCurrentDirectory(),
			ValidateNames = true,
		};
		if (dialog.ShowDialog() != true)
		{
			return;
		}

		var path = dialog.FileName;

		MessageBox.Show(path);
		_dataBase = new ApplicationContext(path);
	}
}
using System;
using System.IO;
using System.Windows;
using EcoFarmAdmin.ViewModels;
using Microsoft.Win32;

namespace EcoFarmAdmin.Models;

public class MainModel
{
	private ApplicationContext? _dataBase;

	public bool IsDbConnected => _dataBase != null;

	public void CreateNewDatabase()
	{
		var dialog = WindowsTransfer.SaveDataBaseDialog();
		if (dialog.ShowDialog() == false)
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
		var dialog = WindowsTransfer.OpenDataBaseDialog();
		if (dialog.ShowDialog() == false)
		{
			return;
		}

		var path = dialog.FileName;

		MessageBox.Show(path);
		_dataBase = new ApplicationContext(path);
	}
}
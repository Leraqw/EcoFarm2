using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using EcoFarmAdmin.Utils;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.EntityState;

namespace EcoFarmAdmin;

public static class DataBaseConnection
{
	static DataBaseConnection() => Application.Current.Windows.OfType<MainWindow>().First().Closing += CloseConnection;

	private static ApplicationContext? _currentContext;

	public static ApplicationContext CurrentContext => _currentContext ?? throw new NullReferenceException();

	public static ObservableCollection<T> Observable<T>()
		where T : class
		=> CurrentContext.GetTable<T>().Local.ToObservableCollection();

	public static bool IsConnected => _currentContext != null;

	public static ApplicationContext OpenDataBase()
	{
		_currentContext = new ApplicationContext();
		_currentContext.Database.Migrate();
		_currentContext.Database.EnsureCreated();

		_currentContext.DevObjects.Load();
		_currentContext.Products.Load();
		_currentContext.Trees.Load();
		_currentContext.Levels.Load();
		_currentContext.DevObjectsOnLevelsStartup.Load();

		return _currentContext;
	}

	private static void CloseConnection(object? sender, CancelEventArgs e)
	{
		if (CancelExit())
		{
			e.Cancel = true;
			return;
		}

		_currentContext?.Dispose();
		_currentContext = null;
	}

	private static bool CancelExit()
	{
		if (HasChanges == false)
		{
			return false;
		}

		var result = MessageBoxUtils.SaveChangesDialog();
		if (result == MessageBoxResult.Yes)
		{
			_currentContext?.SaveChanges();
		}
		else if (result == MessageBoxResult.Cancel)
		{
			return true;
		}

		return false;
	}

	public static bool HasChanges
		=> _currentContext?.ChangeTracker.Entries().Any((e) => e.State is Added or Modified or Deleted) ?? false;
}
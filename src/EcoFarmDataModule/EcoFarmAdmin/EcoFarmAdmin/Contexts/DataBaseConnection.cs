using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
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

		return _currentContext;
	}

	// ReSharper disable once MemberCanBePrivate.Global - is used in App.g.cs

	public static void CloseConnection(object? sender, CancelEventArgs e)
	{
		if (HasChanges)
		{
			var result = MessageBox.Show
			(
				"Данные не были сохранены. Сохранить?",
				"Внимание",
				MessageBoxButton.YesNoCancel,
				MessageBoxImage.Warning
			);
			if (result == MessageBoxResult.Yes)
			{
				_currentContext?.SaveChanges();
			}
			else if (result == MessageBoxResult.Cancel)
			{
				e.Cancel = true;
				return;
			}
		}

		_currentContext?.Dispose();
		_currentContext = null;
	}

	public static bool HasChanges
		=> _currentContext?.ChangeTracker.Entries().Any((e) => e.State is Added or Modified or Deleted) ?? false;
}

public static class PropertyExtensions
{
	public static Visibility AsVisibility(this bool @this) => @this ? Visibility.Visible : Visibility.Hidden;
}
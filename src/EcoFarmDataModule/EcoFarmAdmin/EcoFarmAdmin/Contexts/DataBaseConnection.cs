using System;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.EntityState;

namespace EcoFarmAdmin;

public static class DataBaseConnection
{
	private static ApplicationContext? _currentContext;

	public static ApplicationContext CurrentContext => _currentContext ?? throw new NullReferenceException();

	public static bool IsConnected => _currentContext != null;

	public static ApplicationContext OpenDataBase()
	{
		CloseConnection();
		_currentContext = new ApplicationContext();
		_currentContext.Database.Migrate();
		_currentContext.Database.EnsureCreated();

		_currentContext.DevObjects.Load();
		_currentContext.Products.Load();

		return _currentContext;
	}

	// ReSharper disable once MemberCanBePrivate.Global - is used in App.g.cs
	public static void CloseConnection()
	{
		_currentContext?.SaveChanges();
		_currentContext?.Dispose();
		_currentContext = null;
	}

	public static bool HasChanges
		=> CurrentContext.ChangeTracker.Entries().Any((e) => e.State is Added or Modified or Deleted);
}

public static class PropertyExtensions
{
	public static Visibility AsVisibility(this bool @this) => @this ? Visibility.Visible : Visibility.Hidden;
}
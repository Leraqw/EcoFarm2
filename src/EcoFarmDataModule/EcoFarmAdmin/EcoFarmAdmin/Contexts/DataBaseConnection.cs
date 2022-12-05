using System;
using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public static class DataBaseConnection
{
	private static ApplicationContext? _currentContext;

	public static ApplicationContext CurrentContext => _currentContext ?? throw new NullReferenceException();

	public static bool IsConnected => _currentContext != null;

	public static ApplicationContext CreateDataBase()
	{
		CloseConnection();
		_currentContext = new ApplicationContext();
		_currentContext.Database.EnsureCreated();
		return _currentContext;
	}

	public static ApplicationContext OpenDataBase()
	{
		CloseConnection();
		_currentContext = new ApplicationContext();
		_currentContext.DevObjects.Load();
		return _currentContext;
	}

	// ReSharper disable once MemberCanBePrivate.Global - is used in App.g.cs
	public static void CloseConnection()
	{
		_currentContext?.SaveChanges();
		_currentContext?.Dispose();
		_currentContext = null;
	}
}
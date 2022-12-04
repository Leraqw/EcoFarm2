using Microsoft.EntityFrameworkCore;

namespace EcoFarmAdmin;

public static class DataBaseConnection
{
	public static ApplicationContext? CurrentContext { get; private set; }

	public static bool IsConnected => CurrentContext != null;

	public static ApplicationContext CreateDataBase()
	{
		CloseConnection();
		CurrentContext = new ApplicationContext();
		CurrentContext.Database.EnsureCreated();
		return CurrentContext;
	}
	
	public static ApplicationContext OpenDataBase()
	{
		CloseConnection();
		CurrentContext = new ApplicationContext();
		CurrentContext.DevObjects.Load();
		return CurrentContext;
	}

	// ReSharper disable once MemberCanBePrivate.Global - is used in App.g.cs
	public static void CloseConnection()
	{
		CurrentContext?.SaveChanges();
		CurrentContext?.Dispose();
		CurrentContext = null;
	}
}
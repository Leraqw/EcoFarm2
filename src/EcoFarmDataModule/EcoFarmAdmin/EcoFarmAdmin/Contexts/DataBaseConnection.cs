namespace EcoFarmAdmin;

public static class DataBaseConnection
{
	public static ApplicationContext? CurrentContext { get; private set; }

	public static bool IsConnected => CurrentContext != null;

	public static ApplicationContext CreateDataBase(string path)
	{
		CurrentContext = new ApplicationContext(path);
		CurrentContext.Database.EnsureCreated();
		return CurrentContext;
	}
	
	public static ApplicationContext OpenDataBase(string path)
	{
		CurrentContext = new ApplicationContext(path);
		return CurrentContext;
	}
}
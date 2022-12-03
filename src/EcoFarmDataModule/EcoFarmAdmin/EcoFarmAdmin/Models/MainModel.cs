namespace EcoFarmAdmin.Models;

public class MainModel
{
	public bool IsDbConnected { get; set; } = false;

	public void CreateNewDatabase()
	{
		IsDbConnected = true;
	}

	public void OpenDatabase()
	{
		IsDbConnected = true;
	}
}
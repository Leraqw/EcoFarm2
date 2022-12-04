namespace EcoFarmAdmin.Models;

public class MainModel
{
	public void CreateNewDatabase() => DataBaseConnection.CreateDataBase();

	public void OpenDatabase() => DataBaseConnection.OpenDataBase();
}
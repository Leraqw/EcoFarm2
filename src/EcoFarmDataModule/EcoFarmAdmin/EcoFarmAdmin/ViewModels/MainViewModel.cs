using DevExpress.Mvvm;
using EcoFarmAdmin.Models;

namespace EcoFarmAdmin.ViewModels;

public class MainViewModel : ViewModelBase
{
	public MainViewModel() => new MainModel().OpenDatabase();

	public ICommand<object> ToProductsListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToProductsListWindow,
			() => DataBaseConnection.IsConnected
		);

	public ICommand<object> ToTreesListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToTreesListWindow,
			() => DataBaseConnection.IsConnected
		);

	public ICommand<object> ToLevelsListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToLevelsListWindow,
			() => DataBaseConnection.IsConnected
		);
	
	public ICommand<object> ToResourcesListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToResourcesListWindow,
			() => DataBaseConnection.IsConnected
		);
	
	public ICommand<object> ToGeneratorsListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToGeneratorsListWindow,
			() => DataBaseConnection.IsConnected
		);
	
	public ICommand<object> ToFactoriesListWindow
		=> new DelegateCommand
		(
			WindowsTransfer.ToFactoriesListWindow,
			() => DataBaseConnection.IsConnected
		);
}
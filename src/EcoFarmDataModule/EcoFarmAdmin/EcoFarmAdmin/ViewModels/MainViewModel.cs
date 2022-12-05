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
}
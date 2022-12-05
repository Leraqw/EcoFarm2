using DevExpress.Mvvm;
using EcoFarmAdmin.Models;

namespace EcoFarmAdmin.ViewModels;

public class MainViewModel : ViewModelBase
{
	public MainViewModel() => new MainModel().OpenDatabase();

	public ICommand<object> ToDevObjectsWindow 
		=> new DelegateCommand(WindowsTransfer.ToDevObjectWindow, () => DataBaseConnection.IsConnected);
}
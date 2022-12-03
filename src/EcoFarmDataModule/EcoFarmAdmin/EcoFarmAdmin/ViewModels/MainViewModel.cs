using DevExpress.Mvvm;
using EcoFarmAdmin.Models;

namespace EcoFarmAdmin.ViewModels;

public class MainViewModel : ViewModelBase
{
	private readonly MainModel _model;

	public MainViewModel() => _model = new MainModel();

	public ICommand<object> CreateNewDatabase => new DelegateCommand(_model.CreateNewDatabase);

	public ICommand<object> OpenDatabase => new DelegateCommand(_model.OpenDatabase);

	public ICommand<object> ToDevObjectsWindow 
		=> new DelegateCommand(WindowsTransfer.ToDevObjectWindow, () => _model.IsDbConnected);
}
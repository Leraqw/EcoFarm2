using DevExpress.Mvvm;
using EcoFarmAdmin.Models;

namespace EcoFarmAdmin.ViewModels;

public class MainViewModel : ViewModelBase
{
	private readonly MainModel _model;

	public MainViewModel() => _model = new MainModel();

	public ICommand<object> CreateNewDatabase => new DelegateCommand(_model.CreateNewDatabase);
}
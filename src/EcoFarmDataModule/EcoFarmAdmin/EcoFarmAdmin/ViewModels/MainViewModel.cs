using System.Windows.Input;
using DevExpress.Mvvm;
using EcoFarmAdmin.Models;

namespace EcoFarmAdmin.ViewModels;

public class MainViewModel : ViewModelBase
{
	private readonly MainModel _model;

	public MainViewModel() => _model = new MainModel();

	public ICommand CreateNewDatabaseCommand => new DelegateCommand(_model.CreateNewDatabase);
}
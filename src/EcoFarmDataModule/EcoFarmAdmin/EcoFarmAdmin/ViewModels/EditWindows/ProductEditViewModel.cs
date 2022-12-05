using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class ProductEditViewModel : ViewModelBase
{
	public Product Product { get; set; } = null!;

	public ICommand<Window> Submit => new DelegateCommand<Window>((w) => w.Submit());
}
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public Product? SelectedProduct { get; set; }

	public ObservableCollection<Product> Products
		=> DataBaseConnection.CurrentContext.Products.Local.ToObservableCollection();

	public ICommand<object> AddProduct => new DelegateCommand(DataEditModel.AddProduct);

	public ICommand<Product> EditProduct
		=> new DelegateCommand<Product>
		(
			(p) => DataEditModel.EditProduct(ref p),
			(p) => p is not null
		);

	public ICommand<Product> DeleteProduct
		=> new DelegateCommand<Product>
		(
			DataEditModel.DeleteProduct,
			(p) => p is not null
		);

	public ICommand<object> ApplyChanges => new DelegateCommand(Save);

	private void Save()
	{
		DataEditModel.SaveChanges(SelectedProduct!);
	}
}
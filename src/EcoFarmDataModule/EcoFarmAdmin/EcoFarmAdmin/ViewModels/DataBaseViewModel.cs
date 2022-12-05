using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;
using static Microsoft.EntityFrameworkCore.EntityState;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public Product? SelectedProduct { get; set; }

	public ObservableCollection<Product> Products
		=> DataBaseConnection.CurrentContext.Products.Local.ToObservableCollection();

	public ICommand<object> AddProduct => new DelegateCommand(DataEditModel.AddProduct);

	public bool HasChanges
		=> DataBaseConnection.CurrentContext.ChangeTracker.Entries()
		                     .Any((e) => e.State is Modified or Added or Deleted);
	
	public Visibility HasChangesVisibility
		=> HasChanges ? Visibility.Visible : Visibility.Collapsed;

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

	public ICommand<object> SaveChanges
		=> new DelegateCommand
		(
			Save,
			() => HasChanges
		);

	private void Save() => DataBaseConnection.CurrentContext.SaveChanges();
}
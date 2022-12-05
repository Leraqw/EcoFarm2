using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;
using static Microsoft.EntityFrameworkCore.EntityState;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public Product?   SelectedProduct      { get; set; }
	public Visibility HasChangesVisibility { get; set; }

	// ReSharper disable once UnusedMember.Global - used in style EditableField in App.xaml
	// ReSharper disable once MemberCanBePrivate.Global - same
	public bool Selected => SelectedProduct != null;

	public ObservableCollection<Product> Products
		=> DataBaseConnection.CurrentContext.Products.Local.ToObservableCollection();

	public ICommand<object> AddProduct => new DelegateCommand(DataEditModel.AddProduct);

	public ICommand<Product> DeleteProduct
		=> new DelegateCommand<Product>
		(
			DataEditModel.DeleteProduct,
			(_) => Selected
		);

	public ICommand<object> SaveChanges
		=> new DelegateCommand
		(
			Save,
			() =>
			{
				HasChangesVisibility = HasChanges ? Visibility.Visible : Visibility.Hidden;
				return HasChanges;
			}
		);

	private bool HasChanges
		=> DataBaseConnection.CurrentContext.ChangeTracker.Entries()
		                     .Any((e) => e.State is Added or Modified or Deleted);

	private void Save() => DataBaseConnection.CurrentContext.SaveChanges();
}
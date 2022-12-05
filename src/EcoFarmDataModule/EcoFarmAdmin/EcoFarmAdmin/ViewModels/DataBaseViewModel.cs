using System.Collections.ObjectModel;
using System.Windows;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DataBaseViewModel : ViewModelBase
{
	public DataBaseViewModel() => Refresh();

	public Product?   SelectedProduct      { get; set; }
	public Visibility HasChangesAsVisibility { get; set; }

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
				Refresh();
				return DataBaseConnection.HasChanges;
			}
		);
	
	private void Refresh() => HasChangesAsVisibility = DataBaseConnection.HasChanges.AsVisibility();

	private void Save() => DataBaseConnection.CurrentContext.SaveChanges();
}
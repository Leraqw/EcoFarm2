using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class ProductsViewModel : TableViewModel<Product> { }

public class TreesViewModel : TableViewModel<Tree> { }

public class CommonDataBaseViewModel : ViewModelBase
{
	public ObservableCollection<Product> Products
		=> DataBaseConnection.CurrentContext.Products.Local.ToObservableCollection();

	public ObservableCollection<Tree> Trees => DataBaseConnection.CurrentContext.Trees.Local.ToObservableCollection();
}
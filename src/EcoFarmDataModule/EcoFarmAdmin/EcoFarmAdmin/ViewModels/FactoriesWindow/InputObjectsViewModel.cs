using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class InputObjectsViewModel : TableViewModel<Factory>
{
	public InputProduct? SelectedInputProduct { get; set; }
	public ObservableCollection<InputProduct>? InputProductsForSelectedFactory { get; set; }
	public ICommand<Factory> OnSelectionChangedCommand => new DelegateCommand<Factory>(OnSelectionChanged);
	public ICommand<object> AddInputProductsCommand => new DelegateCommand(AddInputProducts);

	public ICommand<InputProduct> DeleteInputProductsCommand
		=> new DelegateCommand<InputProduct>
		(
			DeleteInputProducts,
			(_) => IsInputProductSelected
		);

	public bool IsInputProductSelected => SelectedInputProduct != null;

	private void AddInputProducts()
	{
		var newInput = new InputProduct { Factory = SelectedItem! };
		InputProducts.Add(newInput);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	private void DeleteInputProducts(InputProduct inputs)
	{
		InputProducts.Remove(inputs);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	protected virtual void OnSelectionChanged(Factory factory)
		=> InputProductsForSelectedFactory = InputProducts
		                                     .Where((ip) => ip.Factory == factory)
		                                     .ToObservableCollection();
}
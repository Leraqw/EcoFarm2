using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class OutputProductsViewModel : InputObjectsViewModel
{
	public OutputProduct? SelectedOutputProduct { get; set; }

	public ObservableCollection<OutputProduct>? OutputProductsForSelectedFactory { get; set; }

	public ICommand<object> AddOutputProductCommand => new DelegateCommand(AddOutputProduct, IsSelected);

	public ICommand<OutputProduct> DeleteOutputProductCommand
		=> new DelegateCommand<OutputProduct>
		(
			DeleteOutputProduct,
			(_) => IsOutputProductSelected
		);

	public bool IsOutputProductSelected => SelectedOutputProduct != null;

	private void AddOutputProduct()
	{
		var newOutput = new OutputProduct { Factory = SelectedItem! };
		OutputProducts.Add(newOutput);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	private void DeleteOutputProduct(OutputProduct outputProduct)
	{
		OutputProducts.Remove(outputProduct);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	protected override void OnSelectionChanged(Factory factory)
	{
		OutputProductsForSelectedFactory = OutputProducts
		                                   .Where((op) => op.Factory == factory)
		                                   .ToObservableCollection();

		base.OnSelectionChanged(factory);
	}
}
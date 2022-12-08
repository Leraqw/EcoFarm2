using System.Linq;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class FactoriesViewModel : OutputProductsViewModel
{
	public FactoriesViewModel() => OnSelectionChanged(Collection.First());

	protected sealed override void OnSelectionChanged(Factory factory)
	{
		SelectedItem = factory;
		base.OnSelectionChanged(factory);
	}
}
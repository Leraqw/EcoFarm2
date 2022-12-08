using System.Linq;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : DevObjectsOnLevelsViewModel
{
	public LevelsViewModel() => OnSelectionChanged(Collection.First());
}
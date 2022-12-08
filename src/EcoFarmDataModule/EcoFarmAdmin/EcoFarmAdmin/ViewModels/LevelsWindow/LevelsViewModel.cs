using System.Linq;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : LevelsGoalsViewModel
{
	public LevelsViewModel() => OnSelectionChanged(Collection.First());
}
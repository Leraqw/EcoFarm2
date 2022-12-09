using System.Linq;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : LevelsGoalsViewModel
{
	public LevelsViewModel() => OnSelectionChanged(Collection.First());

	protected sealed override void OnSelectionChanged(Level level) => base.OnSelectionChanged(level);
}
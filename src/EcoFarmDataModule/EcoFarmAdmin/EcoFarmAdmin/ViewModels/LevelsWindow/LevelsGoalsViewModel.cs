using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsGoalsViewModel : DevObjectsOnLevelsViewModel
{
	public ObservableCollection<Goal>? GoalsOnSelectedLevel { get; set; }

	protected override void OnSelectionChanged(Level level)
	{
		GoalsOnSelectedLevel = Goals
		                       .Where((g) => g.Level == level)
		                       .ToObservableCollection();
		
		base.OnSelectionChanged(level);
	}
}
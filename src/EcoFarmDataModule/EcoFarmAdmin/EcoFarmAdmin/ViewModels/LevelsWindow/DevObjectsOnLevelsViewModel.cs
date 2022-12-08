using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class DevObjectsOnLevelsViewModel : LevelsMoverViewModel
{
	public DevObjectOnLevelStartup? SelectedDosOnStart { get; set; }
	public ObservableCollection<DevObjectOnLevelStartup>? DevObjectOnSelectedLevel { get; set; }
	public ICommand<Level> OnSelectionChangedCommand => new DelegateCommand<Level>(OnSelectionChanged);
	public ICommand<object> AddDosOnStart => new DelegateCommand(AddDevObjectOnStart);

	public ICommand<DevObjectOnLevelStartup> DeleteDosOnStart
		=> new DelegateCommand<DevObjectOnLevelStartup>
		(
			DeleteDevObjectOnStart,
			(_) => IsDosSelected
		);

	public bool IsDosSelected => SelectedDosOnStart != null;

	private void AddDevObjectOnStart()
	{
		var newDl = new DevObjectOnLevelStartup { Level = SelectedItem! };
		DevObjectOnLevelsStartup.Add(newDl);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	private void DeleteDevObjectOnStart(DevObjectOnLevelStartup devObjectOnLevelStartup)
	{
		DevObjectOnLevelsStartup.Remove(devObjectOnLevelStartup);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	protected virtual void OnSelectionChanged(Level level)
		=> DevObjectOnSelectedLevel = DevObjectOnLevelsStartup
		                              .Where((dl) => dl.Level == level)
		                              .ToObservableCollection();
}
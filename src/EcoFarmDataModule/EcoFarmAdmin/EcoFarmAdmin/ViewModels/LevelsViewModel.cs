using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : LevelsMoverViewModel
{
	public LevelsViewModel() => OnSelectionChanged(Collection.First());

	public DevObjectOnLevelStartup?                       SelectedDosOnStart       { get; set; }
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

	protected override void AddItem()
	{
		base.AddItem();

		var item = Collection.Last();
		item.Order = Collection.Max((l) => l.Order) + 1;
		item.Id = Collection.Max((l) => l.Id) + 1;
	}

	protected override void DeleteItem(Level item)
	{
		base.DeleteItem(item);

		Collection.Where((l) => l.Order > item.Order).ForEach((l) => l.Order--);
	}

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

	private void OnSelectionChanged(Level level)
		=> DevObjectOnSelectedLevel = DevObjectOnLevelsStartup
		                              .Where((dl) => dl.Level == level)
		                              .ToObservableCollection();
}
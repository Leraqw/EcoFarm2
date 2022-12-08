using System.Collections.ObjectModel;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class OutputProductsViewModel : DevObjectsOnLevelsViewModel
{
	public Goal? SelectedGoal { get; set; }

	public ObservableCollection<Goal>? GoalsOnSelectedLevel { get; set; }
	public ICommand<object>            AddGoalCommand       => new DelegateCommand(AddGoal);

	public ICommand<Goal> DeleteGoalCommand
		=> new DelegateCommand<Goal>
		(
			DeleteGoal,
			(_) => IsGoalSelected
		);

	public bool IsGoalSelected => SelectedGoal != null;

	private void AddGoal()
	{
		var newGoal = new Goal { Level = SelectedItem! };
		Goals.Add(newGoal);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	private void DeleteGoal(Goal goal)
	{
		Goals.Remove(goal);
		OnSelectionChanged(SelectedItem!);
		Refresh();
	}

	protected override void OnSelectionChanged(Level level)
	{
		GoalsOnSelectedLevel = Goals
		                       .Where((g) => g.Level == level)
		                       .ToObservableCollection();

		base.OnSelectionChanged(level);
	}
}
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : TableViewModel<Level>
{
	public ICommand<Level> MoveUp   => new DelegateCommand<Level>(MoveLevelUp);
	public ICommand<Level> MoveDown => new DelegateCommand<Level>(MoveLevelDown);

	private void MoveLevelUp(Level level)
	{
		var sortedLevels = Collection.OrderBy((l) => l.Order).ToList();
		var indexOfCurrent = sortedLevels.IndexOf((l) => l.Id == level.Id);
		if (indexOfCurrent <= 0)
		{
			return;
		}

		var levelToSwap = sortedLevels[indexOfCurrent - 1];
		(levelToSwap.Order, level.Order) = (level.Order, levelToSwap.Order);
		Refresh();
	}

	private void MoveLevelDown(Level level)
	{ 
		var sortedLevels = Collection.OrderBy((l) => l.Order).ToList();
		var indexOfCurrent = sortedLevels.IndexOf((l) => l.Id == level.Id);
		if (indexOfCurrent >= sortedLevels.Count - 1)
		{
			return;
		}

		var levelToSwap = sortedLevels[indexOfCurrent + 1];
		(levelToSwap.Order, level.Order) = (level.Order, levelToSwap.Order);
		Refresh();
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.Mvvm;
using DevExpress.Mvvm.Native;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : TableViewModel<Level>
{
	public ICommand<Level> MoveUp   => new DelegateCommand<Level>(MoveLevelUp);
	public ICommand<Level> MoveDown => new DelegateCommand<Level>(MoveLevelDown);

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

	private void MoveLevelUp(Level level) => MoveLevel(level, isAtBorder: (i, _) => i <= 0, step: (i) => i - 1);

	private void MoveLevelDown(Level level)
		=> MoveLevel(level, isAtBorder: (i, list) => i >= list.Count - 1, step: (i) => i + 1);

	private void MoveLevel(Level level, Func<int, List<Level>, bool> isAtBorder, Func<int, int> step)
	{
		var sortedLevels = Collection.OrderBy((l) => l.Order).ToList();
		var indexOfCurrent = sortedLevels.IndexOf((l) => l.Id == level.Id);
		if (isAtBorder(indexOfCurrent, sortedLevels))
		{
			return;
		}

		var levelToSwap = sortedLevels[step(indexOfCurrent)];
		(levelToSwap.Order, level.Order) = (level.Order, levelToSwap.Order);
		Refresh();
	}
}
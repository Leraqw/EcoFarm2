using System.Linq;
using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : TableViewModel<Level>
{
	public ICommand<Level> MoveUpCommand => new DelegateCommand<Level>(MoveUp);

	public ICommand<Level> MoveDownCommand => new DelegateCommand<Level>(MoveDown);

	private void MoveUp(Level level)
	{
		// replace level order with previous level order
		Collection.OrderBy((l) => l.Order)
	}

	private void MoveDown(Level level) { }
}
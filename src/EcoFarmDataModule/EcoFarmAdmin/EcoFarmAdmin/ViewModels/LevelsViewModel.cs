using DevExpress.Mvvm;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class LevelsViewModel : TableViewModel<Level>
{
	public ICommand<Level> MoveUp   => new DelegateCommand<Level>(MoveLevelUp);
	public ICommand<Level> MoveDown => new DelegateCommand<Level>(MoveLevelDown);

	private void MoveLevelUp(Level level) { }

	private void MoveLevelDown(Level level) { }
}
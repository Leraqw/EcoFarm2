using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Ui;

namespace Code.Services.Game.Interfaces
{
	public interface IGameServices
		: ISpawnPointsService,
		  IConfigurationService,
		  IUiService { }
}
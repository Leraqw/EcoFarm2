using Code.Services.Game.Interfaces.Config;

namespace Code.Services.Game.Interfaces
{
	public interface IGameServices
		: ISpawnPointsService,
		  IConfigurationService,
		  IUiService { }
}
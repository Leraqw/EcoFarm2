using Code.Services.Game.Interfaces.Config;
using Code.Services.Interfaces;

namespace Code.Services.Game.Interfaces
{
	public interface IGameServices
		: ISpawnPointsService,
		  IConfigurationService,
		  IUiService { }
}
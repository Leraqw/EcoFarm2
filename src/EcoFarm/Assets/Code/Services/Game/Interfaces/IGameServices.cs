using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;

namespace Code.Services.Game.Interfaces
{
	public interface IGameServices
		: ISpawnPointsService,
		  IConfigurationService,
		  IUiService { }
}
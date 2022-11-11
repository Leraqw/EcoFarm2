using Code.Services.Interfaces.Config;

namespace Code.Services.Interfaces
{
	public interface IAllServices
		: IResourcesService,
		  ISpawnPointsService,
		  IStorageService,
		  IDataService,
		  ICameraService,
		  IInputService,
		  IConfigurationService,
		  IUiService { }
}
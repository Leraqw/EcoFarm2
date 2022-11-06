using Code.Services.Interfaces.Config;
using Code.Unity;

namespace Code.Services.Interfaces
{
	public interface IAllServices
		: IResourcesService,
		  ISpawnPointsService,
		  IStorageService,
		  IDataBaseService,
		  ICameraService,
		  IInputService,
		  IConfigurationService,
		  IUiService { }
}
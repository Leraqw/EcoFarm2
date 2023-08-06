namespace EcoFarm
{
	public interface IGlobalServices
		: IResourcesService,
		  IStorageService,
		  IDataService,
		  ICameraService,
		  IInputService,
		  ISceneTransferService { }
}
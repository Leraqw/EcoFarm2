using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class GlobalServicesRegistrationSystem : IInitializeSystem
	{
		private readonly ServicesContext _context;
		private readonly IDataProviderService _dataProviderService;
		private readonly IResourcesService _resourcesService;
		private readonly ICameraService _cameraService;
		private readonly IInputService _inputService;
		private readonly ISceneTransferService _sceneTransferService;

		[Inject]
		public GlobalServicesRegistrationSystem
		(
			ServicesContext context,
			IDataProviderService dataProviderService,
			IResourcesService resourcesService,
			ICameraService cameraService,
			IInputService inputService,
			ISceneTransferService sceneTransferService
		)
		{
			_context = context;

			_sceneTransferService = sceneTransferService;
			_inputService = inputService;
			_cameraService = cameraService;
			_resourcesService = resourcesService;
			_dataProviderService = dataProviderService;
		}

		public void Initialize()
		{
			// _context.ReplaceDataProvider(_dataProviderService);
			// _context.ReplaceResourcesService(_resourcesService);
			// _context.ReplaceCameraService(_cameraService);
			// _context.ReplaceInputService(_inputService);
			// _context.ReplaceSceneTransferService(_sceneTransferService);
		}
	}
}
using System;

namespace Code
{
	public sealed class GlobalServicesRegistrationSystems : Feature
	{
		public GlobalServicesRegistrationSystems(Contexts contexts, IGlobalServices services)
			: base(nameof(GlobalServicesRegistrationSystems))
		{
			var servicesContext = contexts.services;

			Register<IResourcesService>(services, servicesContext.ReplaceResourcesService);
			Register<IStorageService>(services, servicesContext.ReplaceStorageService);
			Register<IDataService>(services, servicesContext.ReplaceDataService);
			Register<ICameraService>(services, servicesContext.ReplaceCameraService);
			Register<IInputService>(services, servicesContext.ReplaceInputService);
			Register<ISceneTransferService>(services, servicesContext.ReplaceSceneTransferService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
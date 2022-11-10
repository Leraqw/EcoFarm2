using System;
using Code.ECS.Systems.Services;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;

namespace Code.ECS.Features.Initialization
{
	public sealed class ServicesRegistrationSystems : Feature
	{
		public ServicesRegistrationSystems(Contexts contexts, IAllServices services)
			: base(nameof(ServicesRegistrationSystems))
		{
			var servicesContext = contexts.services;

			Register<IResourcesService>(services, servicesContext.ReplaceResourcesService);
			Register<ISpawnPointsService>(services, servicesContext.ReplaceSceneObjectsService);
			Register<IStorageService>(services, servicesContext.ReplaceStorageService);
			Register<IDataBaseService>(services, servicesContext.ReplaceDataBaseService);
			Register<ICameraService>(services, servicesContext.ReplaceCameraService);
			Register<IInputService>(services, servicesContext.ReplaceInputService);
			Register<IConfigurationService>(services, servicesContext.ReplaceConfigurationService);
			Register<IUiService>(services, servicesContext.ReplaceUiService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
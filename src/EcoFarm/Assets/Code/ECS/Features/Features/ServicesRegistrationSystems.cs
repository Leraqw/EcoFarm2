using System;
using Code.ECS.Systems.Services;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;

namespace Code.ECS.Features.Features
{
	public sealed class ServicesRegistrationSystems : Feature
	{
		public ServicesRegistrationSystems(Contexts contexts, IGlobalServices services)
			: base(nameof(ServicesRegistrationSystems))
		{
			var servicesContext = contexts.services;

			Register<IResourcesService>(services, servicesContext.ReplaceResourcesService);
			Register<IStorageService>(services, servicesContext.ReplaceStorageService);
			Register<IDataService>(services, servicesContext.ReplaceDataService);
			Register<ICameraService>(services, servicesContext.ReplaceCameraService);
			Register<IInputService>(services, servicesContext.ReplaceInputService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
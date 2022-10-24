using System;
using Code.ECS.Systems.Services;
using Code.Services.Interfaces;

namespace Code.ECS.Features
{
	public sealed class ServicesRegistrationSystems : Feature
	{
		public ServicesRegistrationSystems(Contexts contexts, IAllServices services)
			: base(nameof(ServicesRegistrationSystems))
		{
			var servicesContext = contexts.services;

			Register<IResourcesService>(services, servicesContext.ReplaceResourcesService);
			Register<ISceneObjectsService>(services, servicesContext.ReplaceSceneObjectsService);
			Register<IStorageService>(services, servicesContext.ReplaceStorageService);
			Register<IConfigService>(services, servicesContext.ReplaceConfigService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
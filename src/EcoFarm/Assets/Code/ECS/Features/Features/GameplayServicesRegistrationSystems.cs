using System;
using Code.ECS.Systems.Services;
using Code.Services.Game.Implementations;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Interfaces;
using Code.Unity;

namespace Code.ECS.Features.Features
{
	public sealed class GameplayServicesRegistrationSystems : Feature
	{
		public GameplayServicesRegistrationSystems(Contexts contexts, UnityDependencies dependencies)
			: base(nameof(ServicesRegistrationSystems))
		{
			var servicesContext = contexts.services;
			var services = new UnityGameServices(dependencies);

			Register<ISpawnPointsService>(services, servicesContext.ReplaceSceneObjectsService);
			Register<IConfigurationService>(services, servicesContext.ReplaceConfigurationService);
			Register<IUiService>(services, servicesContext.ReplaceUiService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
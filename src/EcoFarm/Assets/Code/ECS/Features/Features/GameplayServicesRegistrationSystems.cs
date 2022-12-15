using System;
using Code.ECS.Systems.Services;
using Code.Services.Game.Implementations;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Ui;
using Code.Unity;

namespace Code.ECS.Features.Features
{
	public sealed class GameplayServicesRegistrationSystems : Feature
	{
		public GameplayServicesRegistrationSystems(Contexts contexts, UnityDependencies dependencies)
			: base(nameof(GlobalServicesRegistrationSystems))
		{
			var services = new UnityGameServices(dependencies);

			Register<ISpawnPointsService>(services, contexts.services.ReplaceSceneObjectsService);
			Register<IConfigurationService>(services, contexts.services.ReplaceConfigurationService);
			Register<IUiService>(services, contexts.services.ReplaceUiService);
		}

		private void Register<T>(T service, Action<T> replaceService)
			=> Add(new RegisterServiceSystem<T>(service, replaceService));
	}
}
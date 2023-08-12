using Entitas;

namespace EcoFarm
{
	public sealed class GameplayServicesRegistrationSystem : IInitializeSystem
	{
		private readonly ServicesContext _context;
		private readonly UnityDependencies _dependencies;

		public GameplayServicesRegistrationSystem(Contexts contexts, UnityDependencies dependencies)
		{
			_dependencies = dependencies;
			_context = contexts.services;
		}

		public void Initialize()
		{
			_context.ReplaceSceneObjectsService(_dependencies.SpawnPoints);
			_context.ReplaceConfigurationService(_dependencies.UnityConfiguration);
			_context.ReplaceUiService(_dependencies.UiService);
		}
	}
}
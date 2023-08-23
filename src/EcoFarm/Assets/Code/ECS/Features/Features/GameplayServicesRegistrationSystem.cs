using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class GameplayServicesRegistrationSystem : IInitializeSystem
	{
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly IConfigurationService _configurationService;
		private readonly IUiService _uiService;
		private readonly ServicesContext _context;

		[Inject]
		public GameplayServicesRegistrationSystem
		(
			ServicesContext context,
			ISpawnPointsService spawnPointsService,
			IConfigurationService configurationService,
			IUiService uiService
		)
		{
			_context = context;

			_spawnPointsService = spawnPointsService;
			_configurationService = configurationService;
			_uiService = uiService;
		}

		public void Initialize()
		{
			_context.ReplaceSceneObjectsService(_spawnPointsService);
			_context.ReplaceConfigurationService(_configurationService);
			_context.ReplaceUiService(_uiService);
		}
	}
}
using Entitas;

namespace EcoFarm
{
	public sealed class SpawnCraneSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly IConfigurationService _configurationService;

		public SpawnCraneSystem
		(
			Contexts contexts,
			ISpawnPointsService spawnPointsService,
			IConfigurationService configurationService
		)
		{
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
			_contexts = contexts;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Crane"))
			            .Do((e) => e.isCrane = true)
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Crane))
			            .Do((e) => e.AddPosition(_spawnPointsService.Crane));
	}
}
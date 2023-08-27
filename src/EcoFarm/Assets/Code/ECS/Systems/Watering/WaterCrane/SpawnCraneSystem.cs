using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnCraneSystem : IInitializeSystem
	{
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly IConfigurationService _configurationService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public SpawnCraneSystem
		(
			ISpawnPointsService spawnPointsService,
			IConfigurationService configurationService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
			_gameEntityFactory = gameEntityFactory;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("Crane");
			e.isCrane = true;
			e.AddViewPrefab(Resource.Prefab.Crane);
			e.AddPosition(_spawnPointsService.Crane);
		}
	}
}
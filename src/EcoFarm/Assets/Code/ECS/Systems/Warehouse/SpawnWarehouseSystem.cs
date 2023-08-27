using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnWarehouseSystem : IInitializeSystem
	{
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public SpawnWarehouseSystem
		(
			IConfigurationService configurationService,
			ISpawnPointsService spawnPointsService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("Warehouse");
			e.AddViewPrefab(_configurationService.Resource.Prefab.Warehouse);
			e.AddSpawnPosition(_spawnPointsService.Warehouse);
		}
	}
}
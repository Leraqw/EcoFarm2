using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnWarehouseSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;

		[Inject]
		public SpawnWarehouseSystem
		(
			Contexts contexts,
			IConfigurationService configurationService,
			ISpawnPointsService spawnPointsService
		)
		{
			_contexts = contexts;
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
		}

		public void Initialize()
		{
			var e = _contexts.game.CreateEntity();
			e.AddDebugName("Warehouse");
			e.AddViewPrefab(_configurationService.Resource.Prefab.Warehouse);
			e.AddSpawnPosition(_spawnPointsService.Warehouse);
		}
	}
}
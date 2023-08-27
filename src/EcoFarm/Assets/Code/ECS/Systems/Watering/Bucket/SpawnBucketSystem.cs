using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public SpawnBucketSystem
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

		private IBalanceConfig Balance => _configurationService.Balance;

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize()
		{
			var e = _gameEntityFactory.Create();
			e.AddDebugName("Bucket");
			e.isBucket = true;
			e.AddViewPrefab(Resource.Prefab.Bucket);
			e.AddSpriteToLoad(Resource.Sprite.Bucket.Filled);
			e.AddRadius(Balance.Bucket.Radius);
			e.isDraggable = true;
			e.isFilled = true;
			e.AddPosition(_spawnPointsService.Bucket);
			e.AddSpawnPosition(e.position.Value);
		}
	}
}
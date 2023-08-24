using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;

		[Inject]
		public SpawnBucketSystem
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

		private IBalanceConfig Balance => _configurationService.Balance;

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize()
		{
			var e = _contexts.game.CreateEntity();
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
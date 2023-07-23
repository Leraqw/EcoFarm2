


using Entitas;

namespace Code
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBucketSystem(Contexts contexts) => _contexts = contexts;

		private IBalanceConfig Balance => _contexts.GetConfiguration().Balance;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

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
			e.AddPosition(SpawnPointsService.Bucket);
			e.AddSpawnPosition(e.position);
		}
	}
}
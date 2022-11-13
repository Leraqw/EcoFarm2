using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBucketSystem(Contexts contexts) => _contexts = contexts;

		private IBalanceConfig Balance => _contexts.GetConfiguration().Balance;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Bucket"))
			            .Do((e) => e.isBucket = true)
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Bucket))
			            .Do((e) => e.AddSpriteToLoad(Resource.Sprite.Bucket.Filled))
			            .Do((e) => e.AddRadius(Balance.Bucket.Radius))
			            .Do((e) => e.isDraggable = true)
			            .Do((e) => e.isFilled = true)
			            .Do((e) => e.AddPosition(SpawnPointsService.Bucket))
			            .Do((e) => e.AddSpawnPosition(e.position));
	}
}
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants.ResourcePath;

namespace Code.ECS.Systems.Watering.Bucket
{
	public sealed class SpawnBucketSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBucketSystem(Contexts contexts) => _contexts = contexts;

		private IBalanceConfig Balance => _contexts.GetConfiguration().Balance;
		
		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Bucket"))
			            .Do((e) => e.isBucket = true)
			            .Do((e) => e.AddRequireView(Prefab.Bucket))
			            .Do((e) => e.AddRequireSprite(Sprite.Bucket.Filled))
			            .Do((e) => e.AddRadius(Balance.Bucket.Radius))
			            .Do((e) => e.isDraggable = true)
			            .Do((e) => e.isFilled = true)
			            .Do((e) => e.AddPosition(SpawnPointsService.Bucket))
			            .Do((e) => e.AddSpawnPosition(e.position));
	}
}
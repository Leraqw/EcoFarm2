using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Warehouse
{
	public sealed class SpawnWarehouseSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnWarehouseSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Warehouse"))
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Warehouse))
			            .Do((e) => e.AddSpawnPosition(SpawnPointsService.Warehouse));
	}
}
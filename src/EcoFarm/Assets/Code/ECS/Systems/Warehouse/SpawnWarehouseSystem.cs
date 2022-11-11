using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Warehouse
{
	public sealed class SpawnWarehouseSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnWarehouseSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourcePathConfig ResourcePath => _contexts.GetConfiguration().ResourcePath;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Warehouse"))
			            .Do((e) => e.AddViewPrefab(ResourcePath.Prefab.Warehouse))
			            .Do((e) => e.AddSpawnPosition(SpawnPointsService.Warehouse));
	}
}
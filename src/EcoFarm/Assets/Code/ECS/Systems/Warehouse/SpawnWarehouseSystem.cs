



using Entitas;

namespace Code
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




using Entitas;

namespace Code
{
	public sealed class SpawnCraneSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnCraneSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Crane"))
			            .Do((e) => e.isCrane = true)
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Crane))
			            .Do((e) => e.AddPosition(SpawnPointsService.Crane));
	}
}
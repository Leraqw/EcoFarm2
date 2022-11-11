using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Watering.Crane
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
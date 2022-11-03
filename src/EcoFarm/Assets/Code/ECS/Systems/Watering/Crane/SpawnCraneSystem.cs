using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants;

namespace Code.ECS.Systems.Watering.Crane
{
	public sealed class SpawnCraneSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnCraneSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Crane"))
			            .Do((e) => e.isCrane = true)
			            .Do((e) => e.AddRequireView(ResourcePath.Crane))
			            .Do((e) => e.AddPosition(SpawnPointsService.Crane));
	}
}
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants.ResourcePath;

namespace Code.ECS.Systems.Warehouse
{
	public sealed class SpawnWarehouseSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnWarehouseSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Warehouse"))
			            .Do((e) => e.AddRequireView(Prefab.Warehouse))
			            .Do((e) => e.AddSpawnPosition(SpawnPointsService.Warehouse));
	}
}
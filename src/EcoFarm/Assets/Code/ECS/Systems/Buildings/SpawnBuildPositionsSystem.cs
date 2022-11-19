using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Game.Interfaces;
using Code.Services.Game.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Buildings
{
	public sealed class SpawnBuildPositionsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBuildPositionsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize() => SpawnPointsService.Buildings.ForEach(Spawn);

		private void Spawn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Sign"))
			            .Do((e) => e.AddPosition(position))
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Sign))
			            .Do((e) => e.isSign = true);
	}
}
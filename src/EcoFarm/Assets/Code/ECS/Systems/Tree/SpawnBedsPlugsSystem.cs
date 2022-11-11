using System.Linq;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces;
using Code.Services.Interfaces.Config.ResourcesConfigs;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Tree
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Skip(_contexts.game.storage.Value.Levels.First().TreesCount)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.BedPlug))
			            .Do((e) => e.AddSpawnPosition(position))
			            .Do((e) => e.AddDebugName("BedPlug"));
	}
}
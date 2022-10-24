using System.Linq;
using Code.Data;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;
		private IConfigService ConfigService => _contexts.services.configService.Value;

		public void Initialize()
			=> SceneObjectsService
			   .TreeSpawnPositions
			   .Skip(ConfigService.TreesCount)
			   .Select((t) => t.position)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector3 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddRequireView("Environment/Trees Beds/Prefabs/Tree Bed Plug"))
			            .Do((e) => e.AddSpawnPosition(position));
	}
}
using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreesSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnTreesSystem(Contexts contexts) => _contexts = contexts;

		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> SceneObjectsService
			   .TreeSpawnPositions
			   .Select((t) => t.position)
			   .ForEach(SpawnOnPosition);

		private void SpawnOnPosition(Vector3 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isTree = true)
			            .Do((e) => e.AddRequireView("Trees/Prefabs/Tree"))
			            .Do((e) => e.AddSpawnPosition(position));
	}
}
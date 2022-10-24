using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreeSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts) => _contexts = contexts;

		private Vector2 TreeSpawnPosition => SceneObjectsService.TreeSpawnPositions.First().position;
		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isTree = true)
			            .Do((e) => e.AddRequireView("Trees/Prefabs/Tree"))
			            .Do((e) => e.AddSpawnPosition(TreeSpawnPosition));
	}
}
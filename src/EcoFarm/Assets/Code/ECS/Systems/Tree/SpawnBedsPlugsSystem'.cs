using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Tree
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;
		private IDataBaseService DataBaseService => _contexts.services.dataBaseService.Value;

		public void Initialize()
			=> SceneObjectsService
			   .TreeSpawnPositions
			   .Skip(DataBaseService.TreesCount)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddRequireView("Environment/Trees Beds/Prefabs/Tree Bed Plug"))
			            .Do((e) => e.AddSpawnPosition(position));
	}
}
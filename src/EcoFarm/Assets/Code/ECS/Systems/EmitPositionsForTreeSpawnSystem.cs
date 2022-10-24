using System.Linq;
using Code.Data;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems
{
	public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public EmitPositionsForTreeSpawnSystem(Contexts contexts) => _contexts = contexts;

		private ISceneObjectsService SceneObjectsService => _contexts.services.sceneObjectsService.Value;
		private IStorageService StorageService => _contexts.services.storageService.Value;

		public void Initialize()
		{
			var config = StorageService.Load(Config.Default);

			SceneObjectsService
				.TreeSpawnPositions
				.Take(config.TreesCount)
				.Select((t) => t.position)
				.ForEach(RequireTreeOn);
		}

		private void RequireTreeOn(Vector3 position)
			=> _contexts.game.CreateEntity()
			            .AddRequireTreeOnPosition(position);
	}
}
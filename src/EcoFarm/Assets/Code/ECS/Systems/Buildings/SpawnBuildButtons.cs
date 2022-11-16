using Code.Services.Game.Interfaces;
using Code.Utils.Extensions;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Buildings
{
	public sealed class SpawnBuildButtons : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBuildButtons(Contexts contexts) => _contexts = contexts;
		
		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		public void Initialize() => SpawnPointsService.Buildings
		                                              .ForEach(Spawn);

		private void Spawn(Vector2 position)
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("SpawnBuildButton"))
			         .Do((e) => e.AddSpawnPosition(position))
			         .Do((e) => e.isUiElement = true)
			         ;
		}
	}
}
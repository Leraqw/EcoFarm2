using System.Linq;




using Entitas;
using UnityEngine;

namespace Code
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		private ISpawnPointsService SpawnPointsService => _contexts.services.sceneObjectsService.Value;

		private IResourceConfig Resource => _contexts.GetConfiguration().Resource;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> SpawnPointsService
			   .Trees
			   .Skip(_contexts.game.storage.Value.Levels[SelectedLevel].TreesCount)
			   .ForEach(SpawnPlug);

		private void SpawnPlug(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.BedPlug))
			            .Do((e) => e.AddSpawnPosition(position))
			            .Do((e) => e.AddDebugName("BedPlug"));
	}
}
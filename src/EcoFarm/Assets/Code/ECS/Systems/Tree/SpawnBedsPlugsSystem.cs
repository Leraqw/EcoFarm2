using System.Linq;
using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly IConfigurationService _configurationService;

		public SpawnBedsPlugsSystem
		(
			Contexts contexts,
			ISpawnPointsService spawnPointsService,
			IConfigurationService configurationService
		)
		{
			_contexts = contexts;
			_spawnPointsService = spawnPointsService;
			_configurationService = configurationService;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> _spawnPointsService
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
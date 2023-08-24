using Entitas;
using UnityEngine;

namespace EcoFarm
{
	public sealed class SpawnSignsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;

		public SpawnSignsSystem
		(
			Contexts contexts,
			IConfigurationService configurationService,
			ISpawnPointsService spawnPointsService
		)
		{
			_contexts = contexts;
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize() => _spawnPointsService.Buildings.ForEach(Spawn);

		private void Spawn(Vector2 position)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Sign"))
			            .Do((e) => e.AddPosition(position))
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Sign))
			            .Do((e) => e.isSign = true)
			            .MakeAttachable();
	}
}
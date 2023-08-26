using Entitas;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnSignsSystem : IInitializeSystem
	{
		private readonly IConfigurationService _configurationService;
		private readonly ISpawnPointsService _spawnPointsService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public SpawnSignsSystem
		(
			Contexts contexts,
			IConfigurationService configurationService,
			ISpawnPointsService spawnPointsService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_configurationService = configurationService;
			_spawnPointsService = spawnPointsService;
			_gameEntityFactory = gameEntityFactory;
		}

		private IResourceConfig Resource => _configurationService.Resource;

		public void Initialize() => _spawnPointsService.Buildings.ForEach(Spawn);

		private void Spawn(Vector2 position)
			=> _gameEntityFactory.Create()
			            .Do((e) => e.AddDebugName("Sign"))
			            .Do((e) => e.AddPosition(position))
			            .Do((e) => e.AddViewPrefab(Resource.Prefab.Sign))
			            .Do((e) => e.isSign = true)
			            .MakeAttachable();
	}
}
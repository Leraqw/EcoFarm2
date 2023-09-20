using System.Linq;
using Entitas;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public sealed class SpawnBedsPlugsSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ISpawnPointsService _spawnPointsService;
        private readonly IConfigurationService _configurationService;
        private readonly GameEntity.Factory _gameEntityFactory;


        [Inject]
        public SpawnBedsPlugsSystem
        (
            Contexts contexts,
            ISpawnPointsService spawnPointsService,
            IConfigurationService configurationService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _contexts = contexts;
            _spawnPointsService = spawnPointsService;
            _configurationService = configurationService;
            _gameEntityFactory = gameEntityFactory;
        }

        private Level Level => _contexts.game.storage.Value.Levels[SelectedLevel];

        private IResourceConfig Resource => _configurationService.Resource;

        private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

        public void Initialize()
            => _spawnPointsService
                .Trees
                .Skip(Level.AppleTreesCount + Level.PearTreesCount)
                .ForEach(SpawnPlug);

        private void SpawnPlug(Vector2 position)
            => _gameEntityFactory.Create()
                .Do((e) => e.AddViewPrefab(Resource.Prefab.BedPlug))
                .Do((e) => e.AddSpawnPosition(position))
                .Do((e) => e.AddDebugName("BedPlug"));
    }
}
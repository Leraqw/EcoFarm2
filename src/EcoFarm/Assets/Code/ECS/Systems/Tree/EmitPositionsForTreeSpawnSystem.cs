using System.Linq;
using Entitas;
using UnityEngine;
using Zenject;

namespace EcoFarm
{
    public sealed class EmitPositionsForTreeSpawnSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;
        private readonly ISpawnPointsService _spawnPointsService;
        private readonly GameEntity.Factory _gameEntityFactory;

        [Inject]
        public EmitPositionsForTreeSpawnSystem
        (
            Contexts contexts,
            ISpawnPointsService spawnPointsService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _contexts = contexts;
            _spawnPointsService = spawnPointsService;
            _gameEntityFactory = gameEntityFactory;
        }

        private Level Level => _contexts.game.storage.Value.Levels[SelectedLevel];

        private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

        public void Initialize()
        {
            var trees = _spawnPointsService.Trees.ToList();

            var appleTreesCount = Level.AppleTreesCount;
            var pearTreesCount = Level.PearTreesCount;
            
            for (var i = 0; i < appleTreesCount; i++)
            {
                RequireTreeOn(trees[i], ItemName.Apple);
            }

            for (var i = appleTreesCount; i < pearTreesCount + appleTreesCount; i++)
            {
                RequireTreeOn(trees[i], ItemName.Pear);
            }
        }

        private void RequireTreeOn(Vector2 position, ItemName type)
        {
            var entity = _gameEntityFactory.Create();
            entity.AddProductType(type);
            entity.AddRequireTreeOnPosition(position);
        }
    }
}
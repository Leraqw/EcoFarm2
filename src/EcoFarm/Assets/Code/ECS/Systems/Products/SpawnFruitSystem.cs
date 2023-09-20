using System;
using System.Linq;
using Entitas;
using UnityEngine;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class SpawnFruitSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _fruits;
        private readonly IConfigurationService _configurationService;
        private readonly GameEntity.Factory _gameEntityFactory;

        [Inject]
        public SpawnFruitSystem
        (
            GameContext context,
            IConfigurationService configurationService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _configurationService = configurationService;
            _gameEntityFactory = gameEntityFactory;

            _fruits = context.GetGroup(AllOf(Fruitful).AnyOf(SpawnPosition, Position));
        }

        private IFruitConfig FruitConfig => _configurationService.Balance.Fruit;

        public void Execute() => _fruits.ForEach(SpawnFruitFor, @if: IsHasNoFruits);

        private static bool IsHasNoFruits(GameEntity entity) => entity.GetAttachedEntities().Any() == false;

        private void SpawnFruitFor(GameEntity tree)
        {
            var e = _gameEntityFactory.Create();
            e.AddDebugName("Fruit");
            e.AddProduct(tree.tree.Value.Product);
            e.AttachTo(tree);
            e.AddPosition(tree.GetActualPosition() + FruitConfig.SpawnOffset);
            e.AddProportionalScale(FruitConfig.InitialScale);
            e.AddViewPrefab(GetPrefab(tree.productType.Value));
            e.isFruitRequire = true;
            e.AddDuration(FruitConfig.BeforeGrowingTime);
        }

        private GameObject GetPrefab(ItemName itemName) =>
            itemName switch
            {
                ItemName.Apple => _configurationService.Resource.Prefab.Apple,
                ItemName.Pear => _configurationService.Resource.Prefab.Pear,
                _ => throw new ArgumentOutOfRangeException(nameof(itemName), itemName, null)
            };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class SpawnTreeSystem : ReactiveSystem<GameEntity>
    {
        private const float Radius = 2f;

        private readonly Contexts _contexts;
        private readonly IConfigurationService _configurationService;

        public SpawnTreeSystem(Contexts contexts, IConfigurationService configurationService)
            : base(contexts.game)
        {
            _configurationService = configurationService;
            _contexts = contexts;
        }

        private IResourceConfig Resource => _configurationService.Resource;

        private ITreeConfig TreeConfiguration => _configurationService.Balance.Tree;

        private Material DefaultMaterial => _configurationService.Resource.Material.Default;

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(RequireTreeOnPosition, ProductType));

        protected override bool Filter(GameEntity entity) => entity.hasRequireTreeOnPosition && entity.hasProductType;

        protected override void Execute(List<GameEntity> entites) => entites.ForEach(Spawn);

        private void Spawn(GameEntity e)
        {
            e.AddDebugName("Tree");
            e.MakeAttachable();
            e.AddViewPrefab(GetPrefab(e.productType.Value));
            e.AddSpawnPosition(e.requireTreeOnPosition.Value);

            var tree = _contexts.game.storage.Value.Trees.First(t => t.Title == e.productType.Value);
            e.AddTree(tree);

            e.isFruitful = true;
            e.isIsInRadius = false;
            e.RemoveRequireTreeOnPosition();
            e.AddWatering(TreeConfiguration.InitialWatering);
            e.AddRadius(Radius);
            e.AddMaterial(DefaultMaterial);
        }

        private GameObject GetPrefab(ItemName itemName) =>
            itemName switch
            {
                ItemName.Apple => Resource.Prefab.AppleTree,
                ItemName.Pear => Resource.Prefab.PearTree,
                _ => throw new ArgumentOutOfRangeException(nameof(itemName), itemName, null)
            };
    }
}
using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class WaterNearTreeSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _trees;

        public WaterNearTreeSystem(Contexts contexts)
            : base(contexts.game)
            => _trees = contexts.game.GetGroup(GameMatcher.Tree);

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(Filled.Removed());

        protected override bool Filter(GameEntity entity) => entity.hasRadius && entity.hasPosition;

        protected override void Execute(List<GameEntity> entites) => entites.ForEach(WaterNearTrees);

        private void WaterNearTrees(GameEntity bucket) => _trees.ForEach(WaterTree, @if: bucket.IsInRadius);

        private static void WaterTree(GameEntity tree) => tree.isWatered = true;
    }
}
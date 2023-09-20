using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class TreeHighlightSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _trees;
        private readonly IGroup<GameEntity> _buckets;
        private readonly IConfigurationService _configurationService;

        public TreeHighlightSystem(Contexts contexts, IConfigurationService configurationService)
        {
            _configurationService = configurationService;
            _trees = contexts.game.GetGroup(GameMatcher.Tree);
            _buckets = contexts.game.GetGroup(Bucket);
        }

        private Material OutlineMaterial => _configurationService.Resource.Material.Outline;

        private Material DefaultMaterial => _configurationService.Resource.Material.Default;

        public void Execute() => _buckets.ForEach(WaterNearTree);

        private void WaterNearTree(GameEntity bucket)
        {
            _trees.ForEach
            (
                tree => ReplaceTreeMaterial
                (
                    tree,
                    CanBeOutlined(tree, bucket)
                        ? OutlineMaterial
                        : DefaultMaterial
                )
            );
        }

        private void ReplaceTreeMaterial(GameEntity tree, Material material) => tree.ReplaceMaterial(material);

        private static bool CanBeOutlined(GameEntity tree, GameEntity bucket)
            => tree.IsInRadius(bucket) && tree.isFruitful && bucket.isFilled;
    }
}
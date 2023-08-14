using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class TreeHighlightSystem : IExecuteSystem
    {
        private readonly IGroup<GameEntity> _trees;
        private readonly IGroup<GameEntity> _buckets;
        private static IConfigurationService Configuration => Contexts.sharedInstance.GetConfiguration();
        private static Material OutlineMaterial => Configuration.Resource.Material.Outline;
        private static Material DefaultMaterial => Configuration.Resource.Material.Default;

        public TreeHighlightSystem(Contexts contexts)
        {
            _trees = contexts.game.GetGroup(GameMatcher.Tree);
            _buckets = contexts.game.GetGroup(Bucket);
        }

        public void Execute() => _buckets.ForEach(WaterNearTree);

        private void ReplaceTreeMaterial(GameEntity tree, Material material) => tree.ReplaceMaterial(material);

        private void WaterNearTree(GameEntity bucket)
        {
            _trees.ForEach((tree)
                => ReplaceTreeMaterial(tree, CanBeOutlined(tree, bucket)
                    ? OutlineMaterial
                    : DefaultMaterial));
        }

        private static bool CanBeOutlined(GameEntity tree, GameEntity bucket)
            => tree.IsInRadius(bucket) && tree.isFruitful && bucket.isFilled;
    }
}
using Entitas;
using UnityEngine;

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
            _buckets = contexts.game.GetGroup(GameMatcher.Bucket);
        }

        public void Execute() => _buckets.ForEach(WaterNearTree);

        private void ReplaceTreeMaterial(GameEntity tree, Material material) => tree.ReplaceMaterial(material);

        private void WaterNearTree(GameEntity bucket)
        {
            foreach (var tree in _trees)
            {
                ReplaceTreeMaterial(tree, tree.IsInRadius(bucket) && tree.isFruitful
                    ? OutlineMaterial
                    : DefaultMaterial);
            }
        }
        
    }
}
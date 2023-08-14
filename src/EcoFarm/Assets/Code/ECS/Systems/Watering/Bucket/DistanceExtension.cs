using UnityEngine;

namespace EcoFarm
{
    public static class DistanceExtension
    {
        public static bool IsInRadius(this GameEntity tree, GameEntity other)
        {
            tree.isIsInRadius = Vector2.Distance(tree.spawnPosition.Value, other.position.Value) <= other.radius.Value;
            return tree.isIsInRadius;
        }
    }
}
using UnityEngine;

namespace EcoFarm
{
    public static class DistanceExtension
    {
        public static bool IsInRadius(this GameEntity self, GameEntity other)
            => Vector2.Distance( self.spawnPosition.Value, other.position.Value) <= self.radius.Value;
    }
}
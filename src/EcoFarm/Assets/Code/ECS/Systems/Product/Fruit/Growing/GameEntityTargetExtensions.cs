using Code.Utils.Extensions;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public static class GameEntityTargetExtensions
	{
		public static void OnTargetScaleReached(this GameEntity @this)
			=> @this.Do((e) => e.RemoveTargetScale())
			        .Do((e) => e.isGrowth = true);

		public static void OnTargetPositionReached(this GameEntity @this)
			=> @this.Do((e) => e.RemoveTargetPosition())
			        .Do((e) => e.isFell = true);
	}
}
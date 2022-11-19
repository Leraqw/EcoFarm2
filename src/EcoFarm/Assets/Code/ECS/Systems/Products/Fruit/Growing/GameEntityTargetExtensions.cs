using Code.Utils.Extensions;

namespace Code.ECS.Systems.Products.Fruit.Growing
{
	public static class GameEntityTargetExtensions
	{
		public static void OnTargetScaleReached(this GameEntity @this)
			=> @this.Do((e) => e.RemoveTargetScale())
			        .Do((e) => e.isGrowth = true)
			        .SafetyResetDuration();

		public static void OnTargetPositionReached(this GameEntity @this)
			=> @this.Do((e) => e.RemoveTargetPosition())
			        .Do((e) => e.isFell = true)
			        .SafetyResetDuration();

		private static void SafetyResetDuration(this GameEntity @this)
			=> @this.Do((e) => e.duration.Value = 0, @if: (e) => e.hasDuration);
	}
}
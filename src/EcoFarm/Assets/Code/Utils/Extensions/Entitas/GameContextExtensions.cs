using Entitas;

namespace Code.Utils.Extensions.Entitas
{
	public static class GameContextExtensions
	{
		public static ICollector<GameEntity> CreateCollectorAllOf
			(this IContext<GameEntity> context, params IMatcher<GameEntity>[] matchers)
			=> CollectorContextExtension.CreateCollector(context, Matcher<GameEntity>.AllOf(matchers));
	}
}
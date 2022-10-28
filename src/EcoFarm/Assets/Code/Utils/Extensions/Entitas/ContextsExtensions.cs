using Entitas;

namespace Code.Utils.Extensions.Entitas
{
	public static class ContextsExtensions
	{
		public static IGroup<GameEntity> GetGroupAllOf(this Contexts contexts, params IMatcher<GameEntity>[] matchers)
			=> contexts.game.GetGroup(GameMatcher.AllOf(matchers));
	}
}
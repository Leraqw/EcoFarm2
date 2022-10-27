using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Common
{
	public sealed class CheckDurationUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckDurationUpSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Duration).NoneOf(GameMatcher.DurationUp));

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(SetDurationUp, IsDurationUp);

		private static bool IsDurationUp(GameEntity entity) => entity.duration <= 0;

		private static void SetDurationUp(GameEntity entity)
			=> entity
			   .Do((e) => e.isDurationUp = true)
			   .Do((e) => e.RemoveDuration());
	}
}
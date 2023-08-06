


using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class RemoveTargetsOnTimeUpSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public RemoveTargetsOnTimeUpSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(DurationUp).AnyOf(TargetPosition, TargetScale));

		public void Cleanup() => _entities.ForEach(Remove);

		private static void Remove(GameEntity entity)
			=> entity.Do(ReachPosition, @if: (e) => e.hasTargetPosition)
			         .Do(ReachScale, @if: (e) => e.hasTargetScale);

		private static void ReachPosition(GameEntity entity) => entity.OnTargetPositionReached();

		private static void ReachScale(GameEntity entity) => entity.OnTargetScaleReached();
	}
}
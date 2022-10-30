using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class RemoveTargetsOnTimeUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public RemoveTargetsOnTimeUpSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(DurationUp).AnyOf(TargetPosition, TargetScale));

		public void Execute() => _entities.ForEach(Remove);

		private static void Remove(GameEntity entity)
			=> entity.Do((e) => e.RemoveTargetPosition(), @if: (e) => e.hasTargetPosition)
			         .Do((e) => e.RemoveTargetScale(), @if: (e) => e.hasTargetScale);
	}
}
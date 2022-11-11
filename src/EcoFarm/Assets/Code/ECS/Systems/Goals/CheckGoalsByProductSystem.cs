using System.Collections.Generic;
using Entitas;
using Code.Utils.Extensions.Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Goals
{
	public sealed class CheckGoalsByProductSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _goals;

		public CheckGoalsByProductSystem(Contexts contexts)
			: base(contexts.game)
			=> _goals = contexts.game.GetGroup(AllOf(Goal, GameMatcher.Product).NoneOf(GoalCompleted));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Check);

		private void Check(GameEntity item) => _goals.ForEach(Mark, @if: (goal) => IsCompleted(goal, item));

		private static bool IsCompleted(GameEntity goal, GameEntity item)
			=> item.inventoryItem.Value.Count >= goal.goal.Value.TargetQuantity;

		private static void Mark(GameEntity goal) => goal.isGoalCompleted = true;
	}
}
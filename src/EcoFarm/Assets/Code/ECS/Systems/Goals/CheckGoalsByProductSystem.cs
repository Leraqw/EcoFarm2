using System.Collections.Generic;
using Code.Utils.Extensions;
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

		private void Check(GameEntity item) => _goals
		                                       .Do((g) => UpdateQuantities(g, item))
		                                       .Do(MarkCompleted);

		private void UpdateQuantities(IGroup<GameEntity> goals, GameEntity item)
			=> goals.ForEach((g) => g.ReplaceCurrentQuantity(item.inventoryItem.Value.Count));

		private void MarkCompleted(IGroup<GameEntity> goals)
			=> goals.ForEach(Mark, @if: IsCompleted);

		private static bool IsCompleted(GameEntity goal)
			=> goal.currentQuantity.Value >= goal.goal.Value.TargetQuantity;

		private static void Mark(GameEntity goal) => goal.isGoalCompleted = true;
	}
}
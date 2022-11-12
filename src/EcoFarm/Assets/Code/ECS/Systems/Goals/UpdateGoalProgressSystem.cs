using System.Collections.Generic;
using Entitas;
using Code.Utils.Extensions.Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Goals
{
	public sealed class UpdateGoalProgressSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _goals;

		public UpdateGoalProgressSystem(Contexts contexts)
			: base(contexts.game)
			=> _goals = contexts.game.GetGroup(AllOf(Goal, GameMatcher.Product).NoneOf(GoalCompleted));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> items) => items.ForEach(UpdateGoals);

		private void UpdateGoals(GameEntity item) => _goals.ForEach((goal) => UpdateProgress(goal, item));

		private static void UpdateProgress(GameEntity goal, GameEntity item)
			=> goal.ReplaceCurrentQuantity(item.inventoryItem.Value.Count);
	}
}
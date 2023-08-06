using System.Collections.Generic;
using Entitas;

using static GameMatcher;

namespace EcoFarm
{
	public sealed class UpdateProductGoalsProgressSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _goals;

		public UpdateProductGoalsProgressSystem(Contexts contexts)
			: base(contexts.game)
			=> _goals = contexts.game.GetGroup(AllOf(Goal, Product).NoneOf(GoalCompleted));

		private static IMatcher<GameEntity> Product => GameMatcher.Product;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> items) => items.ForEach(UpdateGoals);

		private void UpdateGoals(GameEntity item)
			=> _goals.ForEach((goal) => UpdateProgress(goal, item), @if: item.HasSameProduct);

		private static void UpdateProgress(GameEntity goal, GameEntity item)
			=> goal.ReplaceCurrentQuantity(item.inventoryItem.Value.Count);
	}
}
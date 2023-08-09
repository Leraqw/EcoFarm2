using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class CheckGoalsByProductSystem : ReactiveSystem<GameEntity>
	{
		public CheckGoalsByProductSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(CurrentQuantity);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Mark, @if: IsCompleted);

		private static bool IsCompleted(GameEntity goal)
			=> goal.currentQuantity.Value >= ((GoalByDevObject)goal.goal.Value).TargetQuantity;

		private static void Mark(GameEntity goal) => goal.isGoalCompleted = true;
	}
}
using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Goals
{
	public sealed class CheckGoalsByProductSystem : ReactiveSystem<GameEntity>
	{
		private IGroup<GameEntity> _goals;

		public CheckGoalsByProductSystem(Contexts contexts)
			: base(contexts.game)
			=> _goals = contexts.game.GetGroup(AllOf(Goal, GameMatcher.Product));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Check);

		private void Check(GameEntity item)
		{
			
		}
	}
}
using System.Collections.Generic;
using System.Linq;

using Entitas;
using static EcoFarm.SessionResult;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ObserveGoalCompletionSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _notCompletedGoals;

		public ObserveGoalCompletionSystem(Contexts contexts)
			: base(contexts.game)
		{
			_notCompletedGoals = contexts.game.GetGroup(AllOf(GameMatcher.Goal).NoneOf(GoalCompleted));
			_contexts = contexts;
		}

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GoalCompleted);

		protected override bool Filter(GameEntity entity) => entity.hasGoal;

		protected override void Execute(List<GameEntity> _) => this.Do(GameVictory, @if: AllGoalsIsCompleted);

		private void GameVictory(object _) => _contexts.player.currentPlayerEntity.ReplaceSessionResult(Victory);

		private bool AllGoalsIsCompleted => _notCompletedGoals.GetEntities().Any() == false;
	}
}
using System.Linq;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Data;
using EcoFarmDataModule;
using Entitas;

namespace Code.ECS.Systems.Goals
{
	public sealed class CreateGoalForLevelSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateGoalForLevelSystem(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Levels.First().Goals.ForEach(Create);

		private void Create(Goal goal)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddGoal(goal))
			            .MarkGoal()
			            .Do((e) => e.AddCurrentQuantity(0))
			            .Do((e) => e.AddUiParent(_contexts.services.uiService.Value.GoalsGroup))
			            .Do((e) => e.AddViewPrefab(_contexts.services.uiService.Value.GoalPrefab))
			            .Do((e) => e.isUiElement = true)
			            .Do((e) => e.AddDebugName($"Goal {goal.TargetQuantity} – {goal.GetType().Name}"));
	}
}
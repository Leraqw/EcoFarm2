using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Data;
using EcoFarmModel;
using Entitas;

namespace Code.ECS.Systems.Goals
{
	public sealed class CreateGoalForLevelSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateGoalForLevelSystem(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.game.storage.Value;

		private IUiService UIService => _contexts.services.uiService.Value;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel;

		public void Initialize() => Storage.Levels[SelectedLevel].Goals.ForEach(Create);

		private void Create(Goal goal)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddGoal(goal))
			            .Do((e) => e.isUiElement = true)
			            .MarkGoal()
			            .Do((e) => e.AddCurrentQuantity(0))
			            .Do((e) => e.AddUiParent(UIService.GoalsGroup))
			            .Do((e) => e.AddViewPrefab(UIService.GoalPrefab))
			            .Do((e) => e.AddDebugName($"Goal {goal.TargetQuantity} – {goal.GetType().Name}"));
	}
}
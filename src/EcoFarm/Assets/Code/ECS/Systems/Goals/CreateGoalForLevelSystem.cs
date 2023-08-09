using EcoFarmModel;
using Entitas;

namespace EcoFarm
{
	public sealed class CreateGoalForLevelSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateGoalForLevelSystem(Contexts contexts) => _contexts = contexts;

		private StorageSO Storage => _contexts.game.storage.Value;

		private IUiService UIService => _contexts.services.uiService.Value;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize() => Storage.Levels[SelectedLevel].Goals.ForEach(Create);

		private void Create(GoalSO goal)
		{
			var e = _contexts.game.CreateEntity();
			e.AddGoal(goal);
			e.isUiElement = true;
			e.MarkGoal();
			e.AddCurrentQuantity(0);
			e.AddUiParent(UIService.GoalsGroup);
			e.AddViewPrefab(UIService.GoalPrefab);

			if (goal is GoalByDevObjectSO goalByDevObjectSo)
				e.AddDebugName($"Goal {goalByDevObjectSo.TargetQuantity} – {goalByDevObjectSo.GetType().Name}");
		}
	}
}
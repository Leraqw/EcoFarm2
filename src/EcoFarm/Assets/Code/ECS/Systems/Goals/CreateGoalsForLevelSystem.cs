using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class CreateGoalsForLevelSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		[Inject]
		public CreateGoalsForLevelSystem(Contexts contexts, IUiService uiService)
		{
			_contexts = contexts;
			_uiService = uiService;
		}

		private Storage Storage => _contexts.game.storage.Value;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize() => Storage.Levels[SelectedLevel].Goals.ForEach(Create);

		private void Create(Goal goal)
		{
			var e = _contexts.game.CreateEntity();
			e.AddGoal(goal);
			e.isUiElement = true;
			e.MarkGoal();
			e.AddCurrentQuantity(0);
			e.AddUiParent(_uiService.GoalsGroup);
			e.AddViewPrefab(_uiService.GoalPrefab);

			if (goal is GoalByDevObject goalByDevObjectSo)
				e.AddDebugName($"Goal {goalByDevObjectSo.TargetQuantity} – {goalByDevObjectSo.GetType().Name}");
		}
	}
}
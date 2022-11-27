using Code.Utils.Extensions;
using EcoFarmModel;
using Entitas;

namespace Code.ECS.Systems.Level
{
	public sealed class CreateLevelTimerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateLevelTimerSystem(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.services.dataService.Value.Storage;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("LevelTimer"))
			            .Do((e) => e.AddView(_contexts.services.uiService.Value.TimerView))
			            .Do((e) => e.isLevelTimer = true)
			            .Do((e) => e.AddDuration(Storage.Levels[SelectedLevel].SecondsForLevel));
	}
}
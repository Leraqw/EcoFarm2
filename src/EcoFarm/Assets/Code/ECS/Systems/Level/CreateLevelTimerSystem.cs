using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class CreateLevelTimerSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;
		private readonly IDataProviderService _dataProvider;

		[Inject]
		public CreateLevelTimerSystem(Contexts contexts, IUiService uiService, IDataProviderService dataProvider)
		{
			_uiService = uiService;
			_contexts = contexts;
			_dataProvider = dataProvider;
		}

		private Storage Storage => _dataProvider.Storage;

		private int SelectedLevel => _contexts.player.currentPlayerEntity.selectedLevel.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("LevelTimer"))
			            .Do((e) => e.AddView(_uiService.TimerView))
			            .Do((e) => e.isLevelTimer = true)
			            .Do((e) => e.AddDuration(Storage.Levels[SelectedLevel].SecondsForLevel));
	}
}
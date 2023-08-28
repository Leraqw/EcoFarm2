using Zenject;

namespace EcoFarm
{
	public sealed class GlobalSystems : FeatureBase
	{
		[Inject]
		public GlobalSystems(SystemsFactory factory)
			: base(nameof(GlobalSystems), factory)
		{
			Add<GlobalServicesRegistrationSystem>();

			Add<LoadCurrentPlayerSystem>();
			Add<UpdateCurrentPlayerSystem>();

			Add<OnSessionEndSystem>();
			Add<SaveProgressSystem>();
			Add<ToMainSceneSystem>();

			// Main Menu Systems
			Add<InitializePlayerChoiceWindowSystem>();
			Add<ToggleWindowActivityButtonSystem>();

			Add<ShowGreetingSystem>();

			Add<DeletePlayerSystem>();
			Add<ChangePlayerDataSystem>();

			Add<TogglePlayerButtonsSystem>();
			Add<PlayerListChangedSystem>();
			
			Add<TogglePlayerModeButtons>();

			Add<BindViewsSystem>();

			Add<PlayerEventSystems>();
			Add<GameEventSystems>();
			Add<PlayerCleanupSystems>();
			Add<DestroyDestroyGameSystem>();
		}
	}
}
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

			Add<OnSessionEndSystem>();
			Add<SaveProgressSystem>();

			// Main Menu Systems
			Add<PreparePlayerChoiceWindowSystem>();
			Add<ToggleWindowActivityButtonSystem>();

			Add<ShowGreetingSystem>();

			Add<DeletePlayerSystem>();
			Add<ChangePlayerDataSystem>();
			Add<ChangeModeSystem>();

			Add<TogglePlayerButtonsSystem>();
			Add<PlayerListChangedSystem>();

			Add<BindViewsSystem>();

			Add<PlayerEventSystems>();
			Add<GameEventSystems>();
			Add<PlayerCleanupSystems>();
			Add<DestroyDestroyGameSystem>();
		}
	}
}
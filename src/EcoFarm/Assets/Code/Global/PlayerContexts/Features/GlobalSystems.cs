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

			Add<LoadPlayersSystem>();
			// Add<SetFirstPlayerAsCurrentSystem>();

			Add<OnSessionEndSystem>();
			Add<SaveProgressSystem>();
			Add<ToMainSceneSystem>();

			// Main Menu Systems
			Add<DisableIfNoCurrentPlayerSystem>();

			Add<PreparePlayerChoiceWindowSystem>();
			Add<ToggleActivityButtonSystem>();
			// Add<ChooseCurrentPlayerSystem>();
			Add<BindViewsSystem>();

			Add<PlayerEventSystems>();
			Add<PlayerCleanupSystems>();
			Add<DestroyDestroyGameSystem>();
		}
	}
}
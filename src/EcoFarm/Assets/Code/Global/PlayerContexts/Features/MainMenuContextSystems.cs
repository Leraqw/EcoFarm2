using Zenject;

namespace EcoFarm
{
    public sealed class MainMenuContextSystems : FeatureBase
    {
        [Inject]
        public MainMenuContextSystems(SystemsFactory factory)
            : base(nameof(MainMenuContextSystems), factory)
        {
            Add<InitializePlayerChoiceWindowSystem>();
            Add<ToggleWindowActivityButtonSystem>();

            Add<ShowGreetingSystem>();

            Add<DeletePlayerSystem>();
            Add<ChangePlayerDataSystem>();

            Add<TogglePlayerButtonsSystem>();
          //  Add<PlayerListChangedSystem>();

            Add<TogglePlayerModeButtons>();

            Add<BindViewsSystem>();
            
            Add<PlayerCleanupSystems>();
            Add<DestroyAllPlayerEntitiesSystem>();
        }
    }
}
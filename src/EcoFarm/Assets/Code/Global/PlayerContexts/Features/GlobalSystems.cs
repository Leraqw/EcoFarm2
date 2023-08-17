namespace EcoFarm
{
    public sealed class GlobalSystems : Feature
    {
        public GlobalSystems()
        {
            var contexts = Contexts.sharedInstance;

            Add(new GlobalServicesRegistrationSystem(contexts));

            Add(new LoadPlayersSystem(contexts));
            Add(new SetFirstPlayerAsCurrentSystem(contexts));

            Add(new OnSessionEndSystem(contexts));
            Add(new SaveProgressSystem(contexts));
            Add(new ToMainSceneSystem(contexts));

            // Main Menu Systems
            Add(new DisableIfNoCurrentPlayerSystem(contexts));

            Add(new InitializePlayerChoiceWindowSystem(contexts));
           // Add(new AddViewSystem(contexts));
            Add(new PreparePlayerChoiceWindowSystem(contexts));
            Add(new PlayerChoiceButtonClickSystem(contexts));
            Add(new BindViewsSystem(contexts));
           // Add(new LoadViewForEntitySystem(contexts));

            Add(new PlayerEventSystems(contexts));
            Add(new PlayerCleanupSystems(contexts));
            Add(new DestroyDestroyGameSystem(contexts));
        }

        public void OnUpdate() => this.ExecuteAnd().Cleanup();
    }
}
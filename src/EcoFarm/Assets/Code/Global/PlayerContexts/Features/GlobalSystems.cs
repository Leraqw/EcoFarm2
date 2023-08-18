namespace EcoFarm
{
    public sealed class GlobalSystems : Feature
    {
        public GlobalSystems()
        {
            var contexts = Contexts.sharedInstance;

            Add(new GlobalServicesRegistrationSystem(contexts));

            Add(new LoadPlayersSystem(contexts));
            //  Add(new SetFirstPlayerAsCurrentSystem(contexts));

            Add(new OnSessionEndSystem(contexts));
            Add(new SaveProgressSystem(contexts));
            Add(new ToMainSceneSystem(contexts));

            // Main Menu Systems
            Add(new DisableIfNoCurrentPlayerSystem(contexts));

            Add(new PreparePlayerChoiceWindowSystem(contexts));
            Add(new ToggleActivityButtonSystem(contexts));
          // Add(new ChooseCurrentPlayerSystem(contexts));
            Add(new BindViewsSystem(contexts));

            Add(new PlayerEventSystems(contexts));
            Add(new PlayerCleanupSystems(contexts));
            Add(new DestroyDestroyGameSystem(contexts));
        }

        public void OnUpdate() => this.ExecuteAnd().Cleanup();
    }
}
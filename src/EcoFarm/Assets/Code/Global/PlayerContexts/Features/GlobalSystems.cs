namespace EcoFarm
{
    public sealed class GlobalSystems : Feature
    {
        public GlobalSystems()
        {
            var contexts = Contexts.sharedInstance;

            Add(new GlobalServicesRegistrationSystem(contexts));

            Add(new LoadPlayerSystem(contexts));
            //  Add(new SetFirstPlayerAsCurrentSystem(contexts));

            Add(new OnSessionEndSystem(contexts));
            Add(new SaveProgressSystem(contexts));
            Add(new ToMainSceneSystem(contexts));

            // Main Menu Systems
            Add(new PreparePlayerChoiceWindowSystem(contexts));
            Add(new ToggleWindowActivityButtonSystem(contexts));
            
            Add(new ShowGreetingSystem(contexts));
            
            Add(new DeletePlayerSystem(contexts));
            Add(new ChangePlayerDataSystem(contexts));
            Add(new ChangeModeSystem(contexts));
            
            Add(new PlayerListChangedSystem(contexts));
          
            Add(new BindViewsSystem(contexts));

            Add(new PlayerEventSystems(contexts));
            Add(new GameEventSystems(contexts));
            Add(new PlayerCleanupSystems(contexts));
            Add(new DestroyDestroyGameSystem(contexts));
        }

        public void OnUpdate() => this.ExecuteAnd().Cleanup();
    }
}
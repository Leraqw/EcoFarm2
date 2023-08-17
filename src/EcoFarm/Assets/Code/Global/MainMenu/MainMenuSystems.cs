namespace EcoFarm
{
    public class MainMenuSystems: Feature
    {
        public MainMenuSystems(UnityMainMenuDependencies dependencies)
            : base(nameof(GameContextSystems))
        {
            var contexts = Contexts.sharedInstance;
            Add(new MainMenuServicesRegistrationSystem(contexts, dependencies));
        }

        public void OnUpdate() => this.ExecuteAnd().Cleanup();
    }
}
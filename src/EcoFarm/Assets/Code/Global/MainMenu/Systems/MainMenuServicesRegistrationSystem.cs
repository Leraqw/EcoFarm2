using Entitas;

namespace EcoFarm
{
    public class MainMenuServicesRegistrationSystem : IInitializeSystem
    {
        private readonly ServicesContext _context;
        private readonly UnityMainMenuDependencies _dependencies;

        public MainMenuServicesRegistrationSystem(Contexts contexts, UnityMainMenuDependencies dependencies)
        {
            _dependencies = dependencies;
            _context = contexts.services;
        }

        public void Initialize() => _context.ReplaceUiMainMenuService(_dependencies.UiService);
    }
}
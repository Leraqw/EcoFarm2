using Entitas;

namespace EcoFarm
{
    public class InitializePlayerChoiceWindowSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializePlayerChoiceWindowSystem(Contexts contexts) => _contexts = contexts;

        private IUiService UI => _contexts.services.uiService.Value;

        public void Initialize()
            => _contexts.game.CreateEntity()
                .Do((e) => e.AddDebugName("PlayerChoiceWindow"))
                .Do((e) => e.AddActivate(false))
                .Do((e) => e.AddView(UI.Windows.Players.gameObject))
                .Do((e) => e.addPl(UI.Windows.Players))
                .Do((e) => e.MakeAttachable())
                .Do((e) => e.isRequirePreparation = true);
    }
}
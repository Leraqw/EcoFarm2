using Entitas;
using UnityEngine;

namespace EcoFarm
{
    public class InitializePlayerChoiceWindowSystem : IInitializeSystem
    {
        private readonly Contexts _contexts;

        public InitializePlayerChoiceWindowSystem(Contexts contexts) => _contexts = contexts;

        private IPrefabDataProvider UI => _contexts.services.prefabProvider.Value;

        public void Initialize()
        {
            var e = Contexts.sharedInstance.game.CreateEntity();
            e.AddDebugName("PlayerChoiceWindow");
            e.isPlayerChoiceWindow = true;
            e.isToggled = false;
            e.MakeAttachable();
            e.AddActivate(false);
            
            var enabledView = ServicesMediator.PrefabProvider.EnabledView;
            var playerChoiceView = ServicesMediator.PrefabProvider.PlayerChoiceView;

            e.AddView(playerChoiceView.gameObject);
            enabledView.Register(e);
        }
    }
}
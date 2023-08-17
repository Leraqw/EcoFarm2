using Entitas;

namespace EcoFarm
{
    public class InitializePlayerChoiceWindowSystem : IInitializeSystem
    {
        public InitializePlayerChoiceWindowSystem(Contexts contexts)
        {
        }
        
        public void Initialize()
        {
            var e = Contexts.sharedInstance.game.CreateEntity();
            e.AddDebugName("PlayerChoiceWindow");
            e.isPlayerChoiceWindow = true;
            e.isToggled = false;
            e.MakeAttachable();
            e.AddActivate(false);
            e.isRequirePreparation = true;
        }
    }
}
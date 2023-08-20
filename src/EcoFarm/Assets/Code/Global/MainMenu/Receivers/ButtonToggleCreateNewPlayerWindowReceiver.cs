using System.Linq;
using Entitas;

namespace EcoFarm
{
    public class ButtonToggleCreateNewPlayerWindowReceiver : BaseButtonClickReceiver
    {
        private GameEntity Window =>
            Contexts.sharedInstance.game.GetEntities(GameMatcher.CreateNewPlayerWindow).First();

        protected override void OnButtonClick() => Window.isToggled = true;
    }
}
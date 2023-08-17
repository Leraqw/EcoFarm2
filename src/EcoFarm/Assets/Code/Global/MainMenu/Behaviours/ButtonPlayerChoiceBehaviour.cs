using System.Linq;
using Entitas;

namespace EcoFarm
{
    public class ButtonPlayerChoiceBehaviour : BaseButtonClickReceiver
    {
        private GameEntity Window => Contexts.sharedInstance.game.GetEntities(GameMatcher.PlayerChoiceWindow).First();

        protected override void OnButtonClick() => Window.isToggled = true;
    }
}
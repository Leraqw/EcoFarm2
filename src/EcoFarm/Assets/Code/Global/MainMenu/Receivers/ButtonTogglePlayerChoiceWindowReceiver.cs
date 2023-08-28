namespace EcoFarm
{
    public class ButtonTogglePlayerChoiceWindowReceiver : BaseButtonClickReceiver
    {
        private static GameEntity Window => Contexts.sharedInstance.game.playerChoiceWindowEntity;

        protected override void OnButtonClick() => Window.isToggled = true;
    }
}
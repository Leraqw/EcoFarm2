namespace EcoFarm
{
    public class ButtonDeletePlayerReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick()
            => Contexts.sharedInstance.player.playerToEditEntity.isToDelete = true;
    }
}
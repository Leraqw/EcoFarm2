namespace EcoFarm
{
    public class ButtonEditReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick()
        {
            var entity = Contexts.sharedInstance.player.editModeEntity;
            entity.ReplaceEditMode(true);
            entity.ReplaceInteractable(false);
        }
    }
}
namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToNextLevel : ButtonToGameplay
	{
		protected override void OnButtonClick()
		{
			Contexts.sharedInstance.player.currentPlayerEntity.selectedLevel.Value++;
			
			base.OnButtonClick();
		}
	}
}
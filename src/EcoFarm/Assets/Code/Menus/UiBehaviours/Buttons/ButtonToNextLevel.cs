namespace Code
{
	public class ButtonToNextLevel : ButtonToGameplay
	{
		protected override void OnButtonClick()
		{
			var selectedLevel = Contexts.sharedInstance.player.currentPlayerEntity.selectedLevel;
			selectedLevel.Value++;

			if (selectedLevel > 7)
			{
				selectedLevel.Value = 7;
			}
			
			base.OnButtonClick();
		}
	}
}
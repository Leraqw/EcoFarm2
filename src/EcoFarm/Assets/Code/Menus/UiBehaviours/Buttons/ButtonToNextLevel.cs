namespace Code
{
	public class ButtonToNextLevel : ButtonToGameplay
	{
		private const int LastLevelNumber = 7;

		protected override void OnButtonClick()
		{
			var selectedLevel = Contexts.sharedInstance.player.currentPlayerEntity.selectedLevel;
			selectedLevel.Value++;

			if (selectedLevel.Value > LastLevelNumber)
			{
				selectedLevel.Value = LastLevelNumber;
			}
			
			base.OnButtonClick();
		}
	}
}
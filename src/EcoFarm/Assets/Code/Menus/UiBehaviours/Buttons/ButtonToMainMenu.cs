﻿namespace Code
{
	public class ButtonToMainMenu : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToMainMenuScene();
	}
}
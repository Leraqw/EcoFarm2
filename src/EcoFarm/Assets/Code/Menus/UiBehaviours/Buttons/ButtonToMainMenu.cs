namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToMainMenu : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToMainMenuScene();
	}
}
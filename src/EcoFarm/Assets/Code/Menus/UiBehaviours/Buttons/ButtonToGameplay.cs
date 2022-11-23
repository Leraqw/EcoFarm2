namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToGameplay : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToGameplayScene();
	}
}
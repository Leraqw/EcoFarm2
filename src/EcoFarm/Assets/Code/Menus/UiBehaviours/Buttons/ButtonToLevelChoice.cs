namespace Code.Menus.UiBehaviours.Buttons
{
	public class ButtonToLevelChoice : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToLevelChoice();
	}
}
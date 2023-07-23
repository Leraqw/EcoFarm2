namespace Code
{
	public class ButtonToGameplay : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToGameplayScene();
	}
}
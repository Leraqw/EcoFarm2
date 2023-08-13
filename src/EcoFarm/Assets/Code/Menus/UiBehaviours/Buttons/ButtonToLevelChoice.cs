namespace EcoFarm
{
	public class ButtonToLevelChoice : ButtonToScene
	{
		protected override void OnButtonClick() => SceneTransfer.ToLevelChoice();
	}
}
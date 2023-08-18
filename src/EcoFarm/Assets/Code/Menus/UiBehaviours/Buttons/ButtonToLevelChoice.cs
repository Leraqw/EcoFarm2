namespace EcoFarm
{
	public class ButtonToLevelChoice : ButtonToScene
	{
		
		protected override void OnButtonClick()
		{
			var gameEntities = Contexts.sharedInstance.game.GetEntities();
			gameEntities.ForEach((e) => e.isDestroy = true);
			
			SceneTransfer.ToLevelChoice();
		}
	}
}
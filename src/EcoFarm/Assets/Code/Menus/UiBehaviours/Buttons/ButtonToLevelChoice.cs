namespace EcoFarm
{
    public class ButtonToLevelChoice : ButtonToScene
    {
        private readonly Contexts _contexts = Contexts.sharedInstance;
        
        protected override void OnButtonClick()
        {
            var gameEntities = _contexts.game.GetEntities();
            gameEntities.ForEach((e) => e.isDestroy = true);
            
            SceneTransfer.ToLevelChoice();
        }
    }
}
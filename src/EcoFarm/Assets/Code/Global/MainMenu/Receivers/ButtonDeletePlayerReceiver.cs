using System.Linq;
using Entitas;

namespace EcoFarm
{
    public class ButtonDeletePlayerReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick()
        {
            var playerToDelete =
                Contexts.sharedInstance.player.GetEntities(PlayerMatcher.PlayerToEdit).First();
            
            playerToDelete.isToDelete = true;
        }
    }
}
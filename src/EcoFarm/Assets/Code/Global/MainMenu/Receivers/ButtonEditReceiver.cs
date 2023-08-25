using System.Linq;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonEditReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick()
        {
            var entity = Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First();
            entity.ReplaceEditMode(true);
            entity.ReplaceInteractable(false);
        }
    }
}
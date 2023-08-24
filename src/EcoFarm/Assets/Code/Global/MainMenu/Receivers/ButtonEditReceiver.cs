using System.Linq;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonEditReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick()
        {
            var e = Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First();
            e.ReplaceEditMode(true);
        }
    }
}
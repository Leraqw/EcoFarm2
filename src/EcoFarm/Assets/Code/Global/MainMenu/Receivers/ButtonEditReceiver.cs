using System.Linq;
using Entitas;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonEditReceiver : BaseButtonClickReceiver
    {
        protected override void OnButtonClick() =>
            Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First()
                .ReplaceEditMode(true);
    }
}
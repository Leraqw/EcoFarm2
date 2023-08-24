using UnityEngine;

namespace EcoFarm
{
    public class ToggleActivityButtonReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private BaseViewListener _window;
        [SerializeField] private bool _targetActivity;

        protected override void OnButtonClick() =>
            Context.CreateEntity()
                .Do((e) => e.AddAttachedTo(_window.Entity.attachableIndex.Value))
                .Do((e) => e.AddTargetActivity(_targetActivity));
    }
}
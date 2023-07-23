


using UnityEngine;

namespace Code
{
	public class ToggleActivityButtonReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private BaseViewListener _window;
		[SerializeField] private bool _targetActivity;

		protected override void OnButtonClick()
			=> Context.CreateEntity()
			          .AttachTo(_window.Entity)
			          .Do((e) => e.AddTargetActivity(_targetActivity))
			          .Do((e) => e.isDestroy = true)
		/**/;
	}
}
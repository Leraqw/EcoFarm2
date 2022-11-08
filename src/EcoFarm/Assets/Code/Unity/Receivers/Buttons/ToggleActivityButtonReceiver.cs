using Code.Unity.ViewListeners;
using Code.Utils.Extensions;
using UnityEngine;

namespace Code.Unity.Receivers.Buttons
{
	public class ToggleActivityButtonReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private BaseViewListener _window;
		[SerializeField] private bool _targetActivity;

		protected override void OnButtonClick()
			=> Context.CreateEntity()
			          .Do((e) => e.AddAttachedTo(_window.Entity.attachableIndex))
			          .Do((e) => e.AddTargetActivity(_targetActivity));
	}
}
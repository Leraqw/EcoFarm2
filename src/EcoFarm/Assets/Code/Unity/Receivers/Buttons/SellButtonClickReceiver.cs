using Code.Unity.ViewListeners;
using UnityEngine;

namespace Code.Unity.Receivers.Buttons
{
	public class SellButtonClickReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private SliderValueView _slider;

		protected override void OnButtonClick() => Context.sellDealEntity.AddCount(_slider.Value);
	}
}
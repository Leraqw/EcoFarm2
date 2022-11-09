using Code.Unity.Valuables;
using UnityEngine;

namespace Code.Unity.Receivers.Buttons
{
	public class SellButtonClickReceiver : BaseButtonClickReceiver
	{
		[SerializeField] private Valuable _valuable;

		protected override void OnButtonClick() => Context.sellDealEntity.ReplaceCount(_valuable.Value);
	}
}
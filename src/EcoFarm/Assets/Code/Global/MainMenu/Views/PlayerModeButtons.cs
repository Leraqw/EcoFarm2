using Entitas;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
	public class PlayerModeButtons : MonoBehaviour, IModeButtonsListener
	{
		[field: SerializeField] public BaseButtonClickReceiver PlayerToChooseReceiver { get; set; }
		[field: SerializeField] public BaseButtonClickReceiver PlayerToEditReceiver   { get; set; }

		private void Start()
			=> Contexts.sharedInstance.game
			           .GetEntities(GameMatcher.ModeButtons)
			           .ForEach(e => e.AddModeButtonsListener(this));

		public void OnModeButtons(GameEntity entity, EnabledReceivers enabled, ColorBlock value)
		{
			SetButtonReceiverData(PlayerToChooseReceiver, enabled.PlayerToChoose, value);
			SetButtonReceiverData(PlayerToEditReceiver, enabled.PlayerToEdit, value);
		}

		private static void SetButtonReceiverData(BaseButtonClickReceiver receiver, bool enabled, ColorBlock colors)
		{
			if (receiver != null)
			{
				receiver.enabled = enabled;
				receiver.Button.colors = colors;
			}
		}
	}
}
using System.Linq;
using Entitas;
using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class ButtonSaveEditedPlayerDataReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private TMP_InputField _inputField;

        protected override void OnButtonClick()
        {
            var playerEntity = Contexts.sharedInstance.player
                .GetEntities(PlayerMatcher.PlayerToEdit)
                .First();
            
            var player = playerEntity.playerToEdit.Value.Player;
            var newPlayerData = new Player(_inputField.text, player.CompletedLevelsCount);
            playerEntity.AddEditedPlayerData(newPlayerData);
        }
    }
}
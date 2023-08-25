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
            
            var newPlayerData = new Player(_inputField.text, playerEntity.completedLevelsCount.Value);
            playerEntity.AddEditedPlayerData(newPlayerData);
        }
    }
}
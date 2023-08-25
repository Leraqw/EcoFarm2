using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class ButtonSaveNewPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private TMP_InputField _inputField;
        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;

        protected override void OnButtonClick()
        {
            var enteredName = _inputField.text;
            if (enteredName.IsNicknameUnique() == false)
            {
                Debug.LogWarning($"player with {enteredName} nickname already exists");
                return;
            }
            
            Players.Add(new Player(enteredName, 0));
            PlayersList.SaveChanges();
        }
    }
}
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace EcoFarm
{
    public class ButtonCreateNewPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private TMP_InputField _inputField;
        private readonly PlayerContext _context = Contexts.sharedInstance.player;
        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players;

        protected override void OnButtonClick()
        {
            var enteredName = _inputField.text;
            var e = _context.CreateEntity();
            
            e.isPlayer = true;
            e.isCurrentPlayer = true;
            e.AddSessionResult(SessionResult.None);
            e.AddNickname(enteredName);
            e.AddCompletedLevelsCount(0);

            Players.Add(new Player(enteredName, 0));
            PlayersList.SaveChanges();
        }
    }
}
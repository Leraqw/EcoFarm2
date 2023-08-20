using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
    public class ButtonCreateNewPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private TMP_InputField _inputField;
        private readonly PlayerContext _context = Contexts.sharedInstance.player;
        private static PlayersList PlayersList => ServicesMediator.DataProvider.PlayersList;
        private static List<Player> Players => ServicesMediator.DataProvider.PlayersList.Players as List<Player>;

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
using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonPlayerToChooseReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerViewPrefab;

        private static PlayerEntity PlayerEntity =>
            Contexts.sharedInstance.player.GetEntities(AllOf(PlayerMatcher.Player)).First();
        private static GameEntity Window => Contexts.sharedInstance.game.GetEntities(GameMatcher.PlayerChoiceWindow).First();
        private static List<Player> PlayerList => ServicesMediator.DataProvider.PlayersList.Players;
        
        protected override void OnButtonClick()
        {
            var player = _playerViewPrefab.Player;
            
            PlayerEntity.ReplaceNickname(player.Nickname);
            PlayerEntity.ReplaceCompletedLevelsCount(player.CompletedLevelsCount);
            PlayerList.MovePlayerToTop(player);
            
            Window.isToggled = true;
        }
    }
}
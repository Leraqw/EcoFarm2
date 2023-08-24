using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonPlayerToChooseReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerViewPrefab;

        private static PlayerEntity Player =>
            Contexts.sharedInstance.player.GetEntities(AllOf(PlayerMatcher.Player)).First();
        private GameEntity Window => Contexts.sharedInstance.game.GetEntities(GameMatcher.PlayerChoiceWindow).First();

        protected override void OnButtonClick()
        {
            Player.isCurrentPlayer = true;
            Player.ReplaceNickname(_playerViewPrefab.Player.Nickname);
            Player.ReplaceCompletedLevelsCount(_playerViewPrefab.Player.CompletedLevelsCount);
            
            Window.isToggled = true;
            Debug.Log(Player.nickname.Value);
        }
    }
}
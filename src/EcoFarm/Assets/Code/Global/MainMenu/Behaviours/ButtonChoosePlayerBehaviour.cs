using System.Linq;
using Entitas;
using Entitas.Unity;
using UnityEngine;
using UnityEngine.Serialization;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonChoosePlayerBehaviour : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerViewPrefab;

        private static PlayerEntity Player =>
            Contexts.sharedInstance.player.GetEntities(AllOf(PlayerMatcher.Player, CurrentPlayer)).First();

        protected override void OnButtonClick()
        {
            Player.ReplaceNickname(_playerViewPrefab.Player.Nickname);
            Player.ReplaceCompletedLevelsCount(_playerViewPrefab.Player.CompletedLevelsCount);

            Debug.Log(Player.nickname.Value);
        }
    }
}
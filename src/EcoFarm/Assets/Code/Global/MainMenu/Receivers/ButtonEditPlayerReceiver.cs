using UnityEngine;

namespace EcoFarm
{
    public class ButtonEditPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerViewPrefab;

        protected override void OnButtonClick()
        {
            Debug.Log($"{_playerViewPrefab.Player.Nickname}");
            var e = Contexts.sharedInstance.player.CreateEntity();
            e.AddPlayerToEdit(_playerViewPrefab);
        }
    }
} 
using System.Collections.Generic;
using UnityEngine;

namespace EcoFarm
{
    public class PlayersListTextRegister : StartEntityBehaviour
    {
        [SerializeField] private TextView _textListener;

        private static PlayerContext Context => Contexts.player;
        private static IEnumerable<Player> Players => ServicesMediator.DataProvider.Players;

        private static string PlayerName => Players.ToString();
        
        protected override void Initialize()
        {
            var e = Context.CreateEntity();
            e.AddText(PlayerName);
            e.AddPlayerTextListener(_textListener);
            e.isDestroy = true;
        }
    }
}
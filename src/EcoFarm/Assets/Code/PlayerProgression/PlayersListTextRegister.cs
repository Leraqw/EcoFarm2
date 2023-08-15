using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace EcoFarm
{
    public class PlayersListTextRegister : StartEntityBehaviour
    {
        [SerializeField] private TextView _textListener;

        private static PlayerContext Context => Contexts.player;
        private static IEnumerable<Player> Players => ServicesMediator.DataProvider.Players.ToList();
        
        protected override void Initialize()
        {
            var playersNames= Players.Aggregate("", (current, p) => current + p.Nickname + "\n");
            
            var e = Context.CreateEntity();
            e.AddText(playersNames);
            e.AddPlayerTextListener(_textListener);
            e.isDestroy = true;
        }
    }
}
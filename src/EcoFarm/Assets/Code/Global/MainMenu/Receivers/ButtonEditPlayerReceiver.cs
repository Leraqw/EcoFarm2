using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonEditPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerView;
        private static PlayerContext Context => Contexts.sharedInstance.player;

        protected override void OnButtonClick()
            => Context.GetEntities(EditMode)
                .ForEach(e => e.ReplacePlayerToEdit(_playerView));
    }
}
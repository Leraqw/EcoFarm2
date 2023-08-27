using System.Linq;
using Entitas;
using UnityEngine;
using static PlayerMatcher;

namespace EcoFarm
{
    public class ButtonEditPlayerReceiver : BaseButtonClickReceiver
    {
        [SerializeField] private PlayerView _playerView;

        protected override void OnButtonClick() =>
            Contexts.sharedInstance.player
                .GetEntities(EditMode)
                .First()
                .ReplacePlayerToEdit(_playerView);
    }
}
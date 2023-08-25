﻿using System.Linq;
using Entitas;

namespace EcoFarm
{
    public class ButtonTogglePlayerChoiceWindowReceiver : BaseButtonClickReceiver
    {
        private static GameEntity Window 
            => Contexts.sharedInstance.game.GetEntities(GameMatcher.PlayerChoiceWindow).First();

        protected override void OnButtonClick() => Window.isToggled = true;
    }
}
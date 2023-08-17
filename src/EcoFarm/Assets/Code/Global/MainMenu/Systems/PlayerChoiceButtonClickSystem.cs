using System.Collections.Generic;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceButtonClickSystem : ReactiveSystem<GameEntity>
    {
        public PlayerChoiceButtonClickSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(PlayerChoiceWindow, Toggled));

        protected override bool Filter(GameEntity entity) => entity.isToggled;

        protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

        private static void Toggle(GameEntity window)
        {
            var windowView = window.view.Value;
         
            windowView.SetActive(!windowView.activeSelf);
            window.isToggled = false;
        }
    }
}
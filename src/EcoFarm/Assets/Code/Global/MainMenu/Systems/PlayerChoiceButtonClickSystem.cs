using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
    public class PlayerChoiceButtonClickSystem : ReactiveSystem<GameEntity>
    {
        private readonly Contexts _contexts;
        public PlayerChoiceButtonClickSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(PlayerChoiceWindow, Toggled, Prepared));

        protected override bool Filter(GameEntity entity) => entity.isToggled && entity.isPrepared;

        protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

        private static void Toggle(GameEntity window)
        {
            window.Do((e) => e.isRequirePreparation = true)
                .Do((e) => e.isPrepared = false);
            
            var windowView = window.view.Value;
         
            windowView.SetActive(!windowView.activeSelf);
            window.isToggled = false;
        }
    }
}
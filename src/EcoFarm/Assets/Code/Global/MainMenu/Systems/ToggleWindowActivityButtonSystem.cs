using System.Collections.Generic;
using System.Linq;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
    public class ToggleWindowActivityButtonSystem : ReactiveSystem<GameEntity>
    {
        public ToggleWindowActivityButtonSystem(Contexts contexts) : base(contexts.game)
        {
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(Window, Toggled, Prepared));

        protected override bool Filter(GameEntity entity) => entity.isToggled && entity.isPrepared;
        protected override void Execute(List<GameEntity> entities) => entities.ForEach(Toggle);

        private static void Toggle(GameEntity window)
        {
            window.Do((e) => e.isRequirePreparation = true);

            var windowView = window.view.Value;
            windowView.SetActive(!windowView.activeSelf);
            window.isToggled = false;

            TurnOffEditMode();
        }
        
        private static void TurnOffEditMode()
        {
            var modeEntity = Contexts.sharedInstance.player.GetEntities(PlayerMatcher.EditMode).First();
            if (modeEntity.editMode.Value) modeEntity.ReplaceEditMode(false);
        }
    }
}
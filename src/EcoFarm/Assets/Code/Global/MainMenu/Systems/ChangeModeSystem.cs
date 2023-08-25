using System.Collections.Generic;
using System.Linq;
using Entitas;
using UnityEngine;
using UnityEngine.UI;

namespace EcoFarm
{
    public class ChangeModeSystem : ReactiveSystem<PlayerEntity>
    {
        private static GameContext _context;

        public ChangeModeSystem(Contexts contexts) : base(contexts.player)
            => _context = Contexts.sharedInstance.game;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(PlayerMatcher.EditMode);

        protected override bool Filter(PlayerEntity entity) => entity.hasEditMode;

        protected override void Execute(List<PlayerEntity> entities) => entities.ForEach(ChangeMode);

        private static void ChangeMode(PlayerEntity entity)
        {
            var modeButtonEntity = _context
                .GetEntities(GameMatcher.ModeButtons)
                .ToList();

            var enabled = new EnabledReceivers();
            var selectedColor = new ColorBlock();

            SetMode(entity.editMode.Value, enabled, selectedColor, modeButtonEntity);
        }

        private static void SetMode(bool editMode, EnabledReceivers enabled, 
            ColorBlock selectedColor, List<GameEntity> modeButtonEntity)
        {
            enabled.PlayerToChoose = !editMode;
            enabled.PlayerToEdit = editMode;
            selectedColor = new ModeButtonColorBlocks(editMode ? Color.red : Color.white).ModeButtonColorBlock;
            modeButtonEntity.ForEach(e => TurnModeOn(e, enabled, selectedColor));
        }

        private static void TurnModeOn(GameEntity e, EnabledReceivers enabled, ColorBlock color)
            => e.ReplaceModeButtons(enabled, color);
    }
}
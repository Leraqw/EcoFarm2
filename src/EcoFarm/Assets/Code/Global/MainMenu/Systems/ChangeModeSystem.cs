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

            EnabledReceivers enabled;
            ColorBlock selectedColor;

            if (entity.editMode.Value)
            {
                enabled.PlayerToChoose = false;
                enabled.PlayerToEdit = true;
                selectedColor = new ModeButtonColorBlocks(Color.red).ModeButtonColorBlock;
                modeButtonEntity.ForEach(e => TurnModeOn(e, enabled, selectedColor));
            }
            else
            {
                enabled.PlayerToChoose = true;
                enabled.PlayerToEdit = false;
                selectedColor = new ModeButtonColorBlocks(Color.white).ModeButtonColorBlock;
                modeButtonEntity.ForEach(e => TurnModeOn(e, enabled, selectedColor));
            }

            //    modeButtonEntity.ForEach(UpdateModeButtonView);
        }

        private static void TurnModeOn(GameEntity e, EnabledReceivers enabled, ColorBlock color)
            => e.ReplaceModeButtons(enabled, color);

        private static void UpdateModeButtonView(GameEntity e)
        {
            e.viewPrefab.Value.gameObject
                .GetComponent<IModeButtonsListener>()
                .OnModeButtons(e, e.modeButtons.Enabled, e.modeButtons.Color);
        }
    }
}
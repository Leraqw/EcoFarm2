using System.Collections.Generic;
using System.Linq;
using Entitas;
using Zenject;
using static PlayerMatcher;

namespace EcoFarm
{
    public class TogglePlayerModeButtons : ReactiveSystem<PlayerEntity>
    {
        private readonly PlayerContext _context;
        private IEnumerable<PlayerEntity> ModeButtonEntities => _context.GetEntities(PlayerModeButtonsEnabled);

        [Inject]
        public TogglePlayerModeButtons(Contexts contexts, IDataProviderService dataProvider)
            : base(contexts.player)
            => _context = contexts.player;

        protected override ICollector<PlayerEntity> GetTrigger(IContext<PlayerEntity> context)
            => context.CreateCollector(EditMode);

        protected override bool Filter(PlayerEntity entity) => entity.hasEditMode;

        protected override void Execute(List<PlayerEntity> entities)
        {
            var modeValue = entities.First().editMode.Value;
            ModeButtonEntities.ForEach(e => { e.ReplacePlayerModeButtonsEnabled(modeValue); });
        }
    }
}
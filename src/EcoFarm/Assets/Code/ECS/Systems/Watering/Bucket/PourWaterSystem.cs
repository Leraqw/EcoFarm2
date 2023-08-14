using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class PourWaterSystem : ReactiveSystem<GameEntity>
    {
        private readonly IGroup<GameEntity> _trees;

        public PourWaterSystem(Contexts contexts)
            : base(contexts.game) =>
            _trees = contexts.game.GetGroup(GameMatcher.Tree);

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
            => context.CreateCollector(AllOf(MouseUp, Filled));

        protected override bool Filter(GameEntity entity) => true;

        protected override void Execute(List<GameEntity> entites) => entites.ForEach(PourOut);

        private void PourOut(GameEntity entity) => entity.isFilled = false;
    }
}
using System.Collections.Generic;
using Entitas;

namespace EcoFarm
{
	public sealed class MarkFellFruitAsPickableSystem : ReactiveSystem<GameEntity>
	{
		public MarkFellFruitAsPickableSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Fell);

		protected override bool Filter(GameEntity entity) => entity.isPickable == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Mark);

		private static void Mark(GameEntity entity) => entity.isPickable = true;
	}
}
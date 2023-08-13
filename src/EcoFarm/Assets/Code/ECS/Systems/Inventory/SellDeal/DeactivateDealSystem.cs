using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class DeactivateDealSystem : ReactiveSystem<GameEntity>
	{
		public DeactivateDealSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Count, GameMatcher.SellDeal));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Deactivate);

		private void Deactivate(GameEntity deal) => deal.RemoveCount();
	}
}
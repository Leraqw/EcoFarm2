using System.Collections.Generic;


using Entitas;

namespace EcoFarm
{
	public sealed class CollectedToInventorySystem : ReactiveSystem<GameEntity>
	{
		private readonly GameContext _context;

		public CollectedToInventorySystem(Contexts contexts)
			: base(contexts.game) => _context = contexts.game;

		private IEnumerable<GameEntity> InventoryItems => _context.GetInventoryItems();

		private static int Step => 1;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Collected);

		protected override bool Filter(GameEntity entity) => entity.hasProduct;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseEachCounter);

		private void IncreaseEachCounter(GameEntity product)
			=> InventoryItems.ForEach(IncreaseCount, @if: product.HasSameProduct);

		private static void IncreaseCount(GameEntity entity) => entity.IncreaseInventoryItemCount(Step);
	}
}
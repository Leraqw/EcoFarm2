using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CollectedToInventorySystem : ReactiveSystem<GameEntity>
	{
		private readonly GameContext _context;

		public CollectedToInventorySystem(Contexts contexts)
			: base(contexts.game) => _context = contexts.game;

		private IEnumerable<GameEntity> InventoryItems => _context.GetInventoryItems();

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Collected);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseEachCounter);

		private void IncreaseEachCounter(GameEntity entity)
			=> InventoryItems.ForEach(IncreaseCount, @if: (item) => HasSameFruitType(item, entity));

		private static void IncreaseCount(GameEntity entity) => entity.inventoryItem.Value.Count++;

		private static bool HasSameFruitType(GameEntity item, GameEntity entity)
			=> item.fruitTypeId.Value == entity.fruitTypeId.Value;
	}
}
using System.Collections.Generic;
using Code.ECS.Components;
using Entitas;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Inventory.SellDeal
{
	public sealed class SubtractSoldApplesSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SubtractSoldApplesSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IEnumerable<GameEntity> InventoryItems => _contexts.game.GetEntitiesWithAttachedTo(InventoryIndex);

		private AttachableIndexComponent InventoryIndex => _contexts.game.inventoryEntity.attachableIndex;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(SellDeal, Count));

		private static IMatcher<GameEntity> SellDeal => GameMatcher.SellDeal;

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SubtractFromItems);

		private void SubtractFromItems(GameEntity deal)
			=> InventoryItems.ForEach((item) => Subtract(item, deal), @if: (item) => item.HasSameFruitType(deal));

		private void Subtract(GameEntity item, GameEntity deal)
			=> item.UpdateInventoryItemCount((c) => c - deal.count);
	}
}
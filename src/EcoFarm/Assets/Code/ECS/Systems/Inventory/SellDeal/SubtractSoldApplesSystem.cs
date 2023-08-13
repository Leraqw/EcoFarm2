using System.Collections.Generic;
using Entitas;


using static GameMatcher;

namespace EcoFarm
{
	public sealed class SubtractSoldApplesSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SubtractSoldApplesSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IEnumerable<GameEntity> InventoryItems => _contexts.game.inventoryEntity.GetAttachedEntities();

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(SellDeal, Count));

		private static IMatcher<GameEntity> SellDeal => GameMatcher.SellDeal;

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SubtractFromItems);

		private void SubtractFromItems(GameEntity deal)
			=> InventoryItems.ForEach((item) => Subtract(item, deal), @if: deal.HasSameProduct);

		private void Subtract(GameEntity item, GameEntity deal) => item.DecreaseInventoryItemCount(deal.count.Value);
	}
}
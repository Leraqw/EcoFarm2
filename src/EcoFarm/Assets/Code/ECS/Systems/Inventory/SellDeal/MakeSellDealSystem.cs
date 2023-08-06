using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class MakeSellDealSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public MakeSellDealSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(SellDeal, Count));

		private static IMatcher<GameEntity> SellDeal => GameMatcher.SellDeal;

		private GameEntity Inventory => _contexts.game.inventoryEntity;

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseCoinsCount);

		private void IncreaseCoinsCount(GameEntity deal)
			=> Inventory.IncreaseCoinsCount(deal.count.Value * deal.product.Value.Price);
	}
}
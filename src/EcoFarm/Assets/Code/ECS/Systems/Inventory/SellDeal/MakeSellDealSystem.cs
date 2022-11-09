using System.Collections.Generic;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Inventory.SellDeal
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

		private IBalanceConfig Balance => _contexts.services.configurationService.Value.Balance;

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(IncreaseCoinsCount);

		private void IncreaseCoinsCount(GameEntity deal)
			=> Inventory.IncreaseCoinsCount(deal.count * Balance.Deal.CoinsPerApple);
	}
}
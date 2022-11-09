using System.Collections.Generic;
using Entitas;
using Unity.VisualScripting.FullSerializer.Internal.Converters;
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

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Make);

		private void Make(GameEntity entity)
		{
			_contexts.game.inventoryEntity.coinsCount.Value += entity.count.Value * _contexts.services.configurationService.Value.Balance.Deal.SellPrice;
		}
	}
}
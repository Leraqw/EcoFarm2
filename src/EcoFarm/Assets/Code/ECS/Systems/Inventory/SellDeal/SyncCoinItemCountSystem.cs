using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Inventory.SellDeal
{
	public sealed class SyncCoinItemCountSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SyncCoinItemCountSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.CoinsCount);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Sync);

		private void Sync(GameEntity entity) 
			=> _contexts.game.coinEntity.UpdateInventoryItemCount(entity.coinsCount);
	}
}
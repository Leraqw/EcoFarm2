using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Inventory
{
	public sealed class SyncCoinsValue : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public SyncCoinsValue(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(InventoryItem, Coin));

		protected override bool Filter(GameEntity entity) => entity.isCoin;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Update);

		private void Update(GameEntity item)
			=> _contexts.game.inventoryEntity.ReplaceCoinsCount(item.inventoryItem.Value.Count);
	}
}
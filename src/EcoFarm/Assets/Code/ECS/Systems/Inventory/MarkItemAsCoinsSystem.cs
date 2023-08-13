using System.Collections.Generic;

using Entitas;

namespace EcoFarm
{
	public sealed class MarkItemAsCoinsSystem : ReactiveSystem<GameEntity>
	{
		public MarkItemAsCoinsSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.InventoryItem);

		protected override bool Filter(GameEntity entity)
			=> entity.inventoryItem.Value.Name == Constants.CoinItemName;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(e => e.isCoin = true);
	}
}
using System.Collections.Generic;
using Code.Utils.StaticClasses;
using Entitas;

namespace Code.ECS.Systems.Inventory
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
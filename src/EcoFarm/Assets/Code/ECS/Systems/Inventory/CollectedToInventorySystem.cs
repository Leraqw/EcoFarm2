using System.Collections.Generic;
using Code.ECS.Components;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CollectedToInventorySystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public CollectedToInventorySystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private AttachTargetComponent InventoryIndex => _contexts.game.inventoryEntity.attachTarget;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Collected);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites)
		{
			var items = _contexts.game.GetEntitiesWithAttachedTo(InventoryIndex);
			foreach (var e in entites)
			{
				items.ForEach(IncreaseCount, @if: (i) => i.fruitTypeId == e.fruitTypeId);
			}
		}

		private void IncreaseCount(GameEntity obj)
		{
			throw new System.NotImplementedException();
		}
	}
}
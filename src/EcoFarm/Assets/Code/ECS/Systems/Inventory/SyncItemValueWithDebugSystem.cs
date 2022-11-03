using System.Collections.Generic;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class SyncItemValueWithDebugSystem : ReactiveSystem<GameEntity>
	{
		public SyncItemValueWithDebugSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SetActualDebugName);

		private static void SetActualDebugName(GameEntity obj) => obj.SetActualDebugName();
	}
}
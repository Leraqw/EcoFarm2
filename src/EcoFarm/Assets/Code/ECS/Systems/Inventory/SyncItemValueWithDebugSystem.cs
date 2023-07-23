using System.Collections.Generic;

using Entitas;

namespace Code
{
	public sealed class SyncItemValueWithDebugSystem : ReactiveSystem<GameEntity>
	{
		public SyncItemValueWithDebugSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.InventoryItem);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(SetActualDebugName);

		private static void SetActualDebugName(GameEntity entity) => entity.SetActualDebugName();
	}
}
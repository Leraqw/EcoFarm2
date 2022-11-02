using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Common.DragAndDrop
{
	public sealed class ReturnReleasedDraggableToInitialPositionSystem : ReactiveSystem<GameEntity>
	{
		public ReturnReleasedDraggableToInitialPositionSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Dragging.Removed());

		protected override bool Filter(GameEntity entity) => entity.hasPosition && entity.hasSpawnPosition;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Return);

		private static void Return(GameEntity entity) => entity.ReplacePosition(entity.spawnPosition);
	}
}
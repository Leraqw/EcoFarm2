
using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class ReturnDraggableToInitialSystem : ICleanupSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public ReturnDraggableToInitialSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(Draggable, Position, SpawnPosition));

		public void Cleanup() => _entities.ForEach(Return, @if: IsNotAtPosition);

		private bool IsNotAtPosition(GameEntity entity) => entity.isDragging == false
		                                                   && entity.position.Value != entity.spawnPosition.Value;

		private void Return(GameEntity entity) => entity.ReplacePosition(entity.spawnPosition.Value);
	}
}
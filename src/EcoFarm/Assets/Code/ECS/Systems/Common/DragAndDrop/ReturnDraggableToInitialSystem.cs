using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Common.DragAndDrop
{
	public sealed class ReturnDraggableToInitialSystem : ICleanupSystem
	{
		private readonly GameEntity[] _entities;

		public ReturnDraggableToInitialSystem(Contexts contexts)
			=> _entities = contexts.game.GetEntities(AllOf(Draggable, Position, SpawnPosition));

		public void Cleanup() => _entities.ForEach(Return, @if: IsNotAtPosition);

		private bool IsNotAtPosition(GameEntity entity) => entity.isDragging == false
		                                                   && entity.position.Value != entity.spawnPosition.Value;

		private void Return(GameEntity entity) => entity.ReplacePosition(entity.spawnPosition);
	}
}
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Common.DragAndDrop
{
	public sealed class ReturnDraggableToInitialSystem : ICleanupSystem
	{
		private readonly GameEntity[] _entities;

		public ReturnDraggableToInitialSystem(Contexts contexts) 
			=> _entities = contexts.game.GetEntities(AllOf(Draggable, Position, SpawnPosition));

		public void Cleanup()
		{
			foreach (var entity in _entities)
			{
				if (entity.isDragging == false
				    && entity.position.Value != entity.spawnPosition.Value)
				{
					entity.ReplacePosition(entity.spawnPosition);
				}
			}
		}
	}
}
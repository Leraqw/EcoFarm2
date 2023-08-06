using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class DraggingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public DraggingSystem(Contexts contexts)
		{
			_entities = contexts.game.GetGroup(AllOf(Dragging, Position));
		}

		public void Execute() => _entities.ForEach(Drag);

		private static void Drag(GameEntity entity) => entity.ReplacePosition(ServicesMediator.MouseWorldPosition);
	}
}
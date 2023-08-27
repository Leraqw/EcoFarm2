using Entitas;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class DraggingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;
		private readonly ServicesMediator _servicesMediator;

		[Inject]
		public DraggingSystem(Contexts contexts, ServicesMediator servicesMediator)
		{
			_servicesMediator = servicesMediator;
			_entities = contexts.game.GetGroup(AllOf(Dragging, Position));
		}

		public void Execute() => _entities.ForEach(Drag);

		private void Drag(GameEntity entity) => entity.ReplacePosition(_servicesMediator.MouseWorldPosition);
	}
}
using Code.Services.Interfaces;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Common.DragAndDrop
{
	public sealed class DraggingSystem : IExecuteSystem
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _entities;

		public DraggingSystem(Contexts contexts)
		{
			_contexts = contexts;
			_entities = contexts.game.GetGroup(AllOf(Dragging, Position));
		}

		private ICameraService Camera => _contexts.services.cameraService.Value;
		private IInputService Input => _contexts.services.inputService.Value;
		
		public void Execute() => _entities.ForEach(Drag);

		private void Drag(GameEntity entity) => entity.ReplacePosition(Camera.ScreenToWorldPoint(Input.MousePosition));
	}
}
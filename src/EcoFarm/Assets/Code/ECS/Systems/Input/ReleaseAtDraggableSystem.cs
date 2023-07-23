using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class ReleaseAtDraggableSystem : ReactiveSystem<GameEntity>
	{
		public ReleaseAtDraggableSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseUp, Draggable));

		protected override bool Filter(GameEntity entity) => entity.isDragging;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Release);

		private static void Release(GameEntity entity) => entity.isDragging = false;
	}
}
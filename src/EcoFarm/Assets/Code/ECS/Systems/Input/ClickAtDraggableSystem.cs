using System.Collections.Generic;

using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class ClickAtDraggableSystem : ReactiveSystem<GameEntity>
	{
		public ClickAtDraggableSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Draggable));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkDrag);

		private static void MarkDrag(GameEntity click) => click.Do((e) => e.isDragging = true);
	}
}
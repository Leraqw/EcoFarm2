using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Input
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
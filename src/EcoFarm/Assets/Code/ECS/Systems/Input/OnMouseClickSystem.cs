using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Input
{
	public sealed class OnMouseClickSystem : ReactiveSystem<GameEntity>
	{
		public OnMouseClickSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.MouseClick);

		protected override bool Filter(GameEntity entity) => entity.mouseClick.Value.isPickable;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkClickedEntity);

		private static void MarkClickedEntity(GameEntity click) => MarkAsPicked(click.mouseClick.Value);

		private static void MarkAsPicked(GameEntity entity) => entity.Do((e) => e.isPicked = true)
		                                                             .Do((e) => e.isPickable = false);
	}
}
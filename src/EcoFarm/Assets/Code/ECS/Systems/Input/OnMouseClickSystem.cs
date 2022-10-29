using System.Collections.Generic;
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

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkAsPicked);

		private static void MarkAsPicked(GameEntity entity) => entity.isPicked = true;
	}
}
using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Input
{
	public sealed class ClickAtPickableSystem : ReactiveSystem<GameEntity>
	{
		public ClickAtPickableSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.MouseDown);

		protected override bool Filter(GameEntity entity) => entity.isPickable;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkPicked);

		private static void MarkPicked(GameEntity click) => click.Do((e) => e.isPicked = true)
		                                                         .Do((e) => e.isPickable = false);
	}
}
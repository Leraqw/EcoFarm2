using System.Collections.Generic;

using Entitas;

using static GameMatcher;
namespace EcoFarm
{
	public sealed class ClickAtPickableSystem : ReactiveSystem<GameEntity>
	{
		public ClickAtPickableSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(MouseDown, Pickable));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(MarkPicked);

		private static void MarkPicked(GameEntity click) => click.Do((e) => e.isPicked = true)
		                                                         .Do((e) => e.isPickable = false);
	}
}
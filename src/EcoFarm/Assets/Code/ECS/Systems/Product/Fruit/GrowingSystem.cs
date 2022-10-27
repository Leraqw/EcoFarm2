using System.Collections.Generic;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public class GrowingSystem : ReactiveSystem<GameEntity>
	{
		public GrowingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.AllOf(GameMatcher.Growing, GameMatcher.View));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Grow);

		private static void Grow(GameEntity entity)
		{
			var growing = entity.growing.Value;
			var scale = entity.view.Value.transform.localScale;
			var newScale = growing.Next(scale, 0.1f);
			
			entity.view.Value.transform.localScale = newScale;
			
			if (growing.IsContains(newScale) == false)
			{
				entity.RemoveGrowing();
			}
		}
	}
}
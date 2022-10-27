using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class GrowingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public GrowingSystem(Contexts contexts)
		{
			_entities = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Growing, GameMatcher.View));
		}

		public void Execute() => _entities.ForEach(Grow);

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
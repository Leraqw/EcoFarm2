using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public sealed class CheckGrowthUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckGrowthUpSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Growing, GameMatcher.View);

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity)
			=> entity
			   .Do((e) => e.RemoveGrowing())
			   .Do((e) => e.isGrowth = true);

		private static bool IsGrowth(GameEntity entity)
			=> entity.growing.Value.IsContains(entity.GetLocalScale()) == false;
	}
}
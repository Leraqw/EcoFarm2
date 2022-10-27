using System;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class CheckGrowthUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckGrowthUpSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(GameMatcher.AllOf(GameMatcher.Growing, GameMatcher.View));

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity) => entity.RemoveGrowing();

		private static bool IsGrowth(GameEntity entity)
			=> entity.growing.Value.IsContains(entity.GetLocalScale()) == false;
	}
}
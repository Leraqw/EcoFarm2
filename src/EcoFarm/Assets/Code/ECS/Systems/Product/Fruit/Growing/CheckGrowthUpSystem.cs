using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public sealed class CheckGrowthUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckGrowthUpSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(ProportionalScale, TargetScale));

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(RemoveGrowing, @if: IsGrowth);

		private static void RemoveGrowing(GameEntity entity)
			=> entity.OnTargetScaleReached();

		private static bool IsGrowth(GameEntity entity)
			=> Mathf.Abs(entity.proportionalScale.Value - entity.targetScale.Value) <= Tolerance;
	}
}
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public sealed class GrowingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public GrowingSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(TargetScale, ProportionalScale, Duration);

		public void Execute() => _entities.ForEach(Grow);

		private static void Grow(GameEntity entity) => entity.proportionalScale.Value += GetNextScale(entity);

		private static float GetNextScale(GameEntity entity)
			=> CalculateStep(entity) * Time.deltaTime;

		private static float CalculateStep(GameEntity entity) => ScalesDifference(entity) / entity.duration;

		private static float ScalesDifference(GameEntity entity) 
			=> entity.targetScale - entity.proportionalScale;
	}
}
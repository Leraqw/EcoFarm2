using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Products.Fruit.Growing
{
	public sealed class GrowingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public GrowingSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(TargetScale, ProportionalScale, Duration));

		public void Execute() => _entities.ForEach(Grow);

		private static void Grow(GameEntity entity) => entity.IncreaseProportionalScale(GetNextScale(entity));

		private static float GetNextScale(GameEntity entity)
			=> CalculateStep(entity) * Time.deltaTime;

		private static float CalculateStep(GameEntity entity) => ScalesDifference(entity) / entity.duration;

		private static float ScalesDifference(GameEntity entity) 
			=> entity.targetScale - entity.proportionalScale;
	}
}
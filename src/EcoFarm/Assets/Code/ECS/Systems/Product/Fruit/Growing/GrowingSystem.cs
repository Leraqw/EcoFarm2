using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Product.Fruit.Growing
{
	public sealed class GrowingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public GrowingSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Growing, GameMatcher.View, GameMatcher.Duration);

		public void Execute() => _entities.ForEach(Grow);

		private static void Grow(GameEntity entity) => entity.SetLocalScale(GetNextScale(entity));

		private static Vector3 GetNextScale(GameEntity entity)
			=> entity.growing.Value.Next(entity.GetLocalScale(), GetScaledStep(entity));

		private static float GetScaledStep(GameEntity entity) => GetStep(entity) * Time.deltaTime;

		private static float GetStep(GameEntity entity) => entity.growing.Value.Different.Avg() / entity.duration;
	}
}
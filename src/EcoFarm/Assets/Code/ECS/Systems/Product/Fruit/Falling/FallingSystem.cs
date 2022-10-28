using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class FallingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public FallingSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Falling, GameMatcher.Position, GameMatcher.Duration);

		public void Execute() => _entities.ForEach(Fall);

		private static void Fall(GameEntity entity) => entity.ReplacePosition(GetNextPosition(entity));

		private static Vector3 GetNextPosition(GameEntity entity)
			=> entity.falling.Value.Next(entity.position.Value, GetScaledStep(entity));

		private static float GetScaledStep(GameEntity entity) => GetStep(entity) * Time.deltaTime;

		private static float GetStep(GameEntity entity) => entity.falling.Value.Different.Avg() / entity.duration.Value;
	}
}
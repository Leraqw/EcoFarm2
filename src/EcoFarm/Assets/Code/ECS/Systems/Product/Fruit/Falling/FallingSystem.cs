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
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Falling, GameMatcher.View, GameMatcher.Duration);

		public void Execute() => _entities.ForEach(Fall);

		private void Fall(GameEntity entity)
			=> entity.view.Value.transform.position = GetNextPosition(entity);

		private Vector3 GetNextPosition(GameEntity entity)
			=> entity.falling.Value.Next(entity.GetActualPosition(), GetScaledStep(entity));

		private float GetScaledStep(GameEntity entity)
			=> entity.falling.Value.Different.Avg() / entity.duration.Value * Time.deltaTime;
	}
}
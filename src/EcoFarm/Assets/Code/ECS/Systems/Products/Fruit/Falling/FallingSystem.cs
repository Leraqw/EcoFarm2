
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class FallingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public FallingSystem(Contexts contexts)
			=> _entities = contexts.game.GetGroup(AllOf(TargetPosition, Position, Duration));

		public void Execute() => _entities.ForEach(Fall);

		private static void Fall(GameEntity entity) => entity.IncreasePosition(GetNextPosition(entity));

		private static Vector2 GetNextPosition(GameEntity entity) => CalculateStep(entity) * Time.deltaTime;

		private static Vector2 CalculateStep(GameEntity entity) => PositionsDifference(entity) / entity.duration.Value;

		private static Vector2 PositionsDifference(GameEntity entity)
			=> entity.targetPosition.Value - entity.position.Value;
	}
}
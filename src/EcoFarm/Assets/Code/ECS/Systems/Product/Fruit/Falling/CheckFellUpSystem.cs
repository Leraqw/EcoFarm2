using Code.ECS.Systems.Product.Fruit.Growing;
using Code.ECS.Systems.Watering.Bucket;
using Code.Services.Interfaces.Config;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class CheckFellUpSystem : IExecuteSystem
	{
		private readonly Contexts _contexts;
		private readonly IGroup<GameEntity> _entities;

		public CheckFellUpSystem(Contexts contexts)
		{
			_contexts = contexts;
			_entities = contexts.game.GetGroup(AllOf(TargetPosition, Position));
		}

		private ICommonConfig Constants => _contexts.GetConfiguration().Common;

		public void Execute() => _entities.ForEach(Check);

		private void Check(GameEntity entity) => entity.Do(MarkAsFell, @if: IsFell);

		private static void MarkAsFell(GameEntity entity) => entity.OnTargetPositionReached();

		private bool IsFell(GameEntity entity)
			=> Vector2.Distance(entity.position.Value, entity.targetPosition.Value) <= Constants.Tolerance;
	}
}
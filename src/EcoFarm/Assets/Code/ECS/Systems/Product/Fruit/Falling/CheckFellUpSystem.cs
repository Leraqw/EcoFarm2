﻿using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class CheckFellUpSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public CheckFellUpSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(TargetPosition, Position);

		public void Execute() => _entities.ForEach(Check);

		private static void Check(GameEntity entity) => entity.Do(RemoveFalling, @if: IsFell);

		private static void RemoveFalling(GameEntity entity) => entity.Do((e) => e.RemoveTargetPosition())
		                                                              .Do((e) => e.isFell = true);

		private static bool IsFell(GameEntity entity)
			=> Vector2.Distance(entity.position.Value, entity.targetPosition.Value) <= Constants.Tolerance;
	}
}
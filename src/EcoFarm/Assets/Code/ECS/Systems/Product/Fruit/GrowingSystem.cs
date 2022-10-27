using Code.Utils.Extensions.Entitas;
using Code.Utils.StaticClasses;
using Entitas;
using UnityEngine;

namespace Code.ECS.Systems.Product.Fruit
{
	public sealed class GrowingSystem : IExecuteSystem
	{
		private readonly IGroup<GameEntity> _entities;

		public GrowingSystem(Contexts contexts)
			=> _entities = contexts.GetGroupAllOf(GameMatcher.Growing, GameMatcher.View);

		public void Execute() => _entities.ForEach(Grow);

		private static void Grow(GameEntity entity) => entity.SetLocalScale(GetNextScale(entity));

		private static Vector3 GetNextScale(GameEntity entity)
			=> entity.growing.Value.Next(entity.GetLocalScale(), Constants.Balance.Fruit.GrowingSpeed);
	}
}
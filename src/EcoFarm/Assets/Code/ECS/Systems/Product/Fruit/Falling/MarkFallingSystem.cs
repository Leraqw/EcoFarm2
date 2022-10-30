using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants.Balance.Fruit;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class MarkFallingSystem : ReactiveSystem<GameEntity>
	{
		public MarkFallingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(WillFall, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isWillFall && entity.hasPosition;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Mark);

		private static void Mark(GameEntity entity)
			=> entity.Do((e) => e.AddTargetPosition(PositionWithoutTreeHeight(entity)))
			         .Do((e) => e.isWillFall = false)
			         .Do((e) => e.AddDuration(FallTime));

		private static Vector2 PositionWithoutTreeHeight(GameEntity entity)
			=> entity.GetActualPosition() - SpawnHeight;
	}
}
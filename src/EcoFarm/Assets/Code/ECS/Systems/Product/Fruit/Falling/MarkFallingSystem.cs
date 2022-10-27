using System.Collections.Generic;
using Code.Utils.Common;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants.Balance.Fruit;

namespace Code.ECS.Systems.Product.Fruit.Falling
{
	public sealed class MarkFallingSystem : ReactiveSystem<GameEntity>
	{
		public MarkFallingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.WillFall, GameMatcher.DurationUp);

		protected override bool Filter(GameEntity entity) => entity.isWillFall && entity.hasView;

		protected override void Execute(List<GameEntity> entities) => entities.ForEach(Mark);

		private static void Mark(GameEntity entity) => entity.AddFalling(CreateTreeHeightInterval(entity));

		private static Vector3Interval CreateTreeHeightInterval(GameEntity entity)
			=> new(entity.GetActualPosition(), PositionWithoutTreeHeight(entity));

		private static Vector3 PositionWithoutTreeHeight(GameEntity entity) 
			=> entity.GetActualPosition() - (Vector3)SpawnHeight;
	}
}
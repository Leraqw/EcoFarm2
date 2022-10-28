using System.Collections.Generic;
using Code.Unity.ViewListeners;
using Code.Utils.Common;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using UnityEngine;
using static Code.Utils.StaticClasses.Constants;

namespace Code.ECS.Systems.Product.Fruit.FruitStates
{
	public sealed class WaitBeforeGrowingSystem : ReactiveSystem<GameEntity>
	{
		public WaitBeforeGrowingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollectorAllOf(GameMatcher.FruitRequire, GameMatcher.DurationUp);

		protected override bool Filter(GameEntity entity) => entity.isFruitRequire;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private static void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.AddRequireView(ResourcePath.ApplePrefab))
			   .Do((e) => e.AddRequireViewOfType(typeof(PositionView)))
			   .Do((e) => e.AddGrowing(new Vector3Interval(Vector3.zero, Vector3.one)))
			   .Do((e) => e.AddDuration(Balance.Fruit.GrowingTime))
			   .Do((e) => e.isFruitRequire = false);
	}
}
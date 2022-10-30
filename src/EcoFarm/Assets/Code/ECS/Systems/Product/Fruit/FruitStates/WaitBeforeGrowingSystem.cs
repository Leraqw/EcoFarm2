using System.Collections.Generic;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
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
			   .Do((e) => e.AddTargetScale(Balance.Fruit.FullScale))
			   .Do((e) => e.AddDuration(Balance.Fruit.GrowingTime))
			   .Do((e) => e.isFruitRequire = false);
	}
}
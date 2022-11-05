using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants;
using static Code.Utils.StaticClasses.Constants.ResourcePath.Prefab;
using static GameMatcher;

namespace Code.ECS.Systems.Product.Fruit.Cooldown
{
	public sealed class WaitBeforeGrowingSystem : ReactiveSystem<GameEntity>
	{
		public WaitBeforeGrowingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(FruitRequire, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isFruitRequire;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private static void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.AddRequireView(Apple))
			   .Do((e) => e.AddTargetScale(Balance.Fruit.FullScale))
			   .Do((e) => e.AddDuration(Balance.Fruit.GrowingTime))
			   .Do((e) => e.isFruitRequire = false);
	}
}
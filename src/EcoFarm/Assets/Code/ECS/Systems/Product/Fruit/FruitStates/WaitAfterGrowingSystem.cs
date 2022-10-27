using System.Collections.Generic;
using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants;

namespace Code.ECS.Systems.Product.Fruit.FruitStates
{
	public sealed class WaitAfterGrowingSystem : ReactiveSystem<GameEntity>
	{
		public WaitAfterGrowingSystem(Contexts contexts)
			: base(contexts.game) { }

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(GameMatcher.Growth);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private static void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.isGrowth = false)
			   .Do((e) => e.ReplaceDuration(Balance.Fruit.AfterGrowingTime))
			   .Do((e) => e.isWillFall = true);
	}
}
using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class WaitBeforeGrowingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public WaitBeforeGrowingSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IConfigurationService Configuration => _contexts.GetConfiguration();

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(FruitRequire, DurationUp));

		protected override bool Filter(GameEntity entity) => entity.isFruitRequire;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.AddViewPrefab(Configuration.Resource.Prefab.Apple))
			   .Do((e) => e.AddTargetScale(Configuration.Balance.Fruit.FullScale))
			   .Do((e) => e.AddDuration(Configuration.Balance.Fruit.GrowingTime))
			   .Do((e) => e.isFruitRequire = false);
	}
}
using System.Collections.Generic;



using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class WaitAfterGrowingSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public WaitAfterGrowingSystem(Contexts contexts)
			: base(contexts.game)
			=> _contexts = contexts;

		private IFruitConfig FruitConfig => _contexts.GetConfiguration().Balance.Fruit;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Growth, DurationUp));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(NextState);

		private void NextState(GameEntity entity)
			=> entity
			   .Do((e) => e.isGrowth = false)
			   .Do((e) => e.AddDuration(FruitConfig.AfterGrowingTime))
			   .Do((e) => e.isWillFall = true);
	}
}
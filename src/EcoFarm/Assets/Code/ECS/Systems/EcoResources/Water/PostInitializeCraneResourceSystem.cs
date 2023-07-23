using System.Collections.Generic;


using Entitas;
using static GameMatcher;

namespace Code
{
	public sealed class PostInitializeCraneResourceSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public PostInitializeCraneResourceSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IBucketConfig BalanceBucket => _contexts.services.configurationService.Value.Balance.Bucket;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Crane);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Initialize);

		private void Initialize(GameEntity crane)
			=> crane.Do((e) => e.AddConsumer(_contexts.game.waterResourceEntity.consumable))
			        .Do((e) => e.AddConsumptionCoefficient(BalanceBucket.WaterConsumption))
		/**/;
	}
}
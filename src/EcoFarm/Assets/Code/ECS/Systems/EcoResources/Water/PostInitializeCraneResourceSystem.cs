using System.Collections.Generic;
using Entitas;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PostInitializeCraneResourceSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		private readonly IConfigurationService _configurationService;

		[Inject]
		public PostInitializeCraneResourceSystem(Contexts contexts, IConfigurationService configurationService)
			: base(contexts.game)
		{
			_contexts = contexts;
			_configurationService = configurationService;
		}

		private IBucketConfig BalanceBucket => _configurationService.Balance.Bucket;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Crane);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Initialize);

		private void Initialize(GameEntity crane)
			=> crane.Do((e) => e.AddConsumer(_contexts.game.waterResourceEntity.consumable.Value))
			        .Do((e) => e.AddConsumptionCoefficient(BalanceBucket.WaterConsumption))
		/**/;
	}
}
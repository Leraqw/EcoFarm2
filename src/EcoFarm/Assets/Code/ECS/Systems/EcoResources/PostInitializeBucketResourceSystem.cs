using System.Collections.Generic;
using Code.Services.Game.Interfaces.Config.BalanceConfigs;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.EcoResources
{
	public sealed class PostInitializeBucketResourceSystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;
		public PostInitializeBucketResourceSystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private IBucketConfig BalanceBucket => _contexts.services.configurationService.Value.Balance.Bucket;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(Crane);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Initialize);

		private void Initialize(GameEntity bucket)
			=> bucket
			   .Do((e) => e.AddConsumer(_contexts.game.waterResourceEntity.consumable))
			   .Do((e) => e.AddConsumptionCoefficient(BalanceBucket.WaterConsumption))
		/**/;
	}
}
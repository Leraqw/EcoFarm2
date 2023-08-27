using System.Collections.Generic;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class PerformProductsRequestSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _products;
		private readonly IConfigurationService _configurationService;

		public PerformProductsRequestSystem(Contexts contexts,IConfigurationService configurationService)
			: base(contexts.game)
		{
			_configurationService = configurationService;
			_products = contexts.game.GetGroup(AllOf(GameMatcher.Product, Collected).NoneOf(InFactory));
		}

		private float RoadToFactoryDuration => Balance.RoadToFactoryDuration;

		private float SendProductToFactoryDelay => Balance.SendProductToFactoryDelay;

		private IFactoryConfig Balance => _configurationService.Balance.Factory;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(RequireProduct, Count).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Perform);

		private void Perform(GameEntity request)
		{
			if (LeftProductsToSend(request))
				SendWithCoolDown(request);
			else
				MarkAsPerformed(request);
		}

		private static bool LeftProductsToSend(GameEntity entity) => entity.count.Value > 0;

		private void SendWithCoolDown(GameEntity entity)
		{
			SendFirstMatch(entity);
			WaitBeforeSendNext(entity);
		}

		private void MarkAsPerformed(GameEntity request)
		{
			var factory = request.GetAttachableEntity();
			factory.isReady = true;
			factory.AddDuration(RoadToFactoryDuration);

			request.isDestroy = true;
		}

		private void WaitBeforeSendNext(GameEntity request)
		{
			request.ReplaceCount(request.count.Value - 1);
			request.ReplaceDuration(SendProductToFactoryDelay);
		}

		private void SendFirstMatch(GameEntity request) => Send(request, _products.FirstProductFor(request));

		private void Send(GameEntity request, GameEntity e)
		{
			e.ReplaceTargetPosition(request.position.Value);
			e.ReplaceDuration(RoadToFactoryDuration);
			e.isInFactory = true;
		}
	}
}
using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using static Code.Utils.StaticClasses.Constants;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class PerformProductsRequestSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _products;

		public PerformProductsRequestSystem(Contexts contexts) : base(contexts.game)
			=> _products = contexts.game.GetGroup(AllOf(Product, Collected).NoneOf(InFactory));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(RequireProduct, Count).NoneOf(Duration));

		protected override bool Filter(GameEntity entity) => entity.hasDuration == false;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Perform);

		private void Perform(GameEntity request)
			=> request.Do
			(
				@if: LeftProductsToSend,
				@true: SendWithCoolDown,
				@false: MarkAsPerformed
			);

		private static bool LeftProductsToSend(GameEntity e) => e.count > 0;

		private void SendWithCoolDown(GameEntity entity) => entity.Do(SendFirstMatch).Do(WaitBeforeSendNext);

		private static void MarkAsPerformed(GameEntity entity)
			=> entity
			   .Do
			   (
				   (e) => e.GetAttachableEntity()
				           .Do((factory) => factory.isReady = true)
				           .Do((factory) => factory.ReplaceDuration(RoadToFactoryDuration))
			   )
			   .Do((e) => e.isDestroy = true)
		/**/;

		private static void WaitBeforeSendNext(GameEntity request)
			=> request
			   .Do((e) => e.ReplaceCount(request.count - 1))
			   .Do((e) => e.ReplaceDuration(SendProductToFactoryDelay))
		/**/;

		private void SendFirstMatch(GameEntity request)
			=> _products
			   .GetEntities()
			   .First((e) => e.product.Value == request.requireProduct.Value)
			   .Do((product) => Send(request, product))
		/**/;

		private static void Send(GameEntity request, GameEntity product)
			=> product
			   .Do((e) => e.AddTargetPosition(request.position))
			   .Do((e) => e.AddDuration(RoadToFactoryDuration))
			   .Do((e) => e.isInFactory = true)
		/**/;
	}
}
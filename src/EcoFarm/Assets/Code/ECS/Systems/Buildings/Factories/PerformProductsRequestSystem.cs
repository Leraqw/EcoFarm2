using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions;
using Entitas;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class PerformProductsRequestSystem : ReactiveSystem<GameEntity>
	{
		private readonly IGroup<GameEntity> _products;

		public PerformProductsRequestSystem(Contexts contexts) : base(contexts.game)
			=> _products = contexts.game.GetGroup(AllOf(Product, Collected).NoneOf(InFactory));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(RequireProduct);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Perform);

		private void Perform(GameEntity r)
			=> _products
			   .GetEntities()
			   .Where((e) => e.product.Value == r.requireProduct.Value)
			   .ForEach((product) => Send(r, product));

		private static GameEntity Send(GameEntity request, GameEntity product)
			=> product
			   .Do((e) => e.AddTargetPosition(request.position))
			   .Do((e) => e.AddDuration(1))
			   .Do((e) => e.isInFactory = true);
	}
}
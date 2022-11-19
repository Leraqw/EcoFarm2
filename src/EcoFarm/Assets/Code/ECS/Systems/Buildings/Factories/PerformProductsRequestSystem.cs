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
			=> _products = contexts.game.GetGroup(AllOf(Product, Collected));

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(RequireProducts);

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Perform);

		private void Perform(GameEntity request)
			=> _products
			   .GetEntities()
			   .Where((e) => e.product.Value == request.product.Value)
			   .ForEach((e) => e.AddTargetPosition(request.position));
	}
}
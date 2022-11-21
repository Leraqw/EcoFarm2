using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using EcoFarmDataModule;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class ClickOnFactorySystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		private Dictionary<Product, int> _requiredProducts;

		public ClickOnFactorySystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private Dictionary<Product, int> AvailableProducts
			=> _contexts.game.GetInventoryItems()
			            .ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, MouseDown).NoneOf(Busy));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites) => entites.ForEach(Handle);

		private void Handle(GameEntity factory)
			=> factory
			   .Do((e) => _requiredProducts = e.RequiredProducts())
			   .Do(TakeProducts, @if: IsEnoughOnWarehouse)
		/**/;

		private bool IsEnoughOnWarehouse(GameEntity factory)
			=> _requiredProducts.All((p) => AvailableProducts[p.Key] >= p.Value);

		private void TakeProducts(GameEntity factory)
			=> factory
			   .Do(MarkAsBusy)
			   .Do(TakeEachRequiredProducts)
		/**/;

		private static void MarkAsBusy(GameEntity entity) => entity.isBusy = true;

		private void TakeEachRequiredProducts(GameEntity factory) 
			=> _requiredProducts.ForEach((p) => Take(p, factory));

		private void Take(KeyValuePair<Product, int> product, GameEntity factory)
		{
			CreateRequest(product, factory);
			DecreaseProductsCount(product);
		}

		private void CreateRequest(KeyValuePair<Product, int> product, GameEntity factory)
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddRequireProduct(product.Key))
			            .Do((e) => e.AddPosition(factory.position))
			            .Do((e) => e.AddCount(product.Value))
			            .AttachTo(factory)
		/**/;

		private void DecreaseProductsCount(KeyValuePair<Product, int> product)
			=> _contexts.game.GetInventoryItem(product.Key)
			            .DecreaseInventoryItemCount(product.Value)
		/**/;
	}
}
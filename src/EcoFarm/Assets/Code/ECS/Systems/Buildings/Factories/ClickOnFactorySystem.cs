using System.Collections.Generic;
using System.Linq;
using Entitas;
using static GameMatcher;

namespace EcoFarm
{
	public sealed class ClickOnFactorySystem : ReactiveSystem<GameEntity>
	{
		private readonly GameContext _context;

		private Dictionary<Product, int> _requiredProducts;
		private readonly GameEntity.Factory _gameEntityFactory;

		public ClickOnFactorySystem(GameContext context, GameEntity.Factory gameEntityFactory)
			: base(context)
		{
			_context = context;
			_gameEntityFactory = gameEntityFactory;
		}

		private Dictionary<Product, int> AvailableProducts
			=> _context.GetInventoryItems().ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(GameMatcher.Factory, MouseDown).NoneOf(Busy));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> factories) => factories.ForEach(Handle);

		private void Handle(GameEntity factory)
		{
			_requiredProducts = factory.RequiredProducts();

			if (IsEnoughResources(factory))
				TakeProducts(factory);
		}

		private bool IsEnoughResources(GameEntity factory)
			=> factory.IsResourceEnough() && IsEnoughOnWarehouse();

		private bool IsEnoughOnWarehouse()
			=> _requiredProducts.All((p) => AvailableProducts[p.Key] >= p.Value);

		private void TakeProducts(GameEntity factory)
		{
			factory.isBusy = true;
			_requiredProducts.ForEach((p) => Take(p, factory));
		}

		private void Take(KeyValuePair<Product, int> product, GameEntity factory)
		{
			CreateRequest(product, factory);
			DecreaseProductsCount(product);
		}

		private void CreateRequest(KeyValuePair<Product, int> product, GameEntity factory)
		{
			var e = _gameEntityFactory.Create();
			e.AddRequireProduct(product.Key);
			e.AddPosition(factory.position.Value);
			e.AddCount(product.Value);
			e.AttachTo(factory);
		}

		private void DecreaseProductsCount(KeyValuePair<Product, int> product)
			=> _context.GetInventoryItem(product.Key)
			           .DecreaseInventoryItemCount(product.Value);
	}
}
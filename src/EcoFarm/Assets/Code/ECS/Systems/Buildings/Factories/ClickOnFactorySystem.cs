using System.Collections.Generic;
using System.Linq;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;
using EcoFarmDataModule;
using UnityEngine;
using static GameMatcher;

namespace Code.ECS.Systems.Buildings.Factories
{
	public sealed class ClickOnFactorySystem : ReactiveSystem<GameEntity>
	{
		private readonly Contexts _contexts;

		public ClickOnFactorySystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, MouseDown));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites)
		{
			entites.ForEach((e) => Debug.Log($"Is enough products: {IsEnoughOnWarehouse(e)}"));
			// entites.ForEach(TakeProducts, @if: IsEnoughOnWarehouse);
		}

		private bool IsEnoughOnWarehouse(GameEntity entity)
		{
			var products = entity.factory.Value.InputProducts;
			var items = _contexts.game.GetInventoryItems().ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

			return products.All((p) => CountOfAvailableProducts(items, p) >= CountOfRequestedProducts(products, p));
		}

		private static int CountOfRequestedProducts(IEnumerable<Product> products, Product product)
			=> products.Count((p) => p == product);

		private static int CountOfAvailableProducts(Dictionary<Product, int> items, Product product)
			=> items.Single((i) => i.Key == product).Value;

		private void TakeProducts(GameEntity entity) { }
	}

	public static class TempExt
	{
		public static int CountOf<T>(this IEnumerable<T> @this, T @object) => @this.Count((o) => o.Equals(@object));
	}
}
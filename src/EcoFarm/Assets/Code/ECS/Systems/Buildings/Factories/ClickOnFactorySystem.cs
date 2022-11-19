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

		private Dictionary<Product, int> AvailableProducts
			=> _contexts.game.GetInventoryItems()
			            .ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

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
			var groups = GetGroups(entity);
			var requiredProducts = groups.ToDictionary(x => x.Key, x => x.Count());

			return groups.All((p) => AvailableProducts[p.Key] >= requiredProducts[p.Key]);
		}

		private static IGrouping<Product, Product>[] GetGroups(GameEntity entity)
		{
			var groups = entity.factory.Value.InputProducts.GroupBy(x => x);
			return groups as IGrouping<Product, Product>[] ?? groups.ToArray();
		}

		private void TakeProducts(GameEntity entity) { }
	}
}
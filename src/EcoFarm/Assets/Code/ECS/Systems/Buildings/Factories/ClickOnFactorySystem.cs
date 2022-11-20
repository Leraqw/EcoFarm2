﻿using System.Collections.Generic;
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

		public ClickOnFactorySystem(Contexts contexts) : base(contexts.game) => _contexts = contexts;

		private Dictionary<Product, int> AvailableProducts
			=> _contexts.game.GetInventoryItems()
			            .ToDictionary((i) => i.product.Value, (i) => i.inventoryItem.Value.Count);

		protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
			=> context.CreateCollector(AllOf(Factory, MouseDown));

		protected override bool Filter(GameEntity entity) => true;

		protected override void Execute(List<GameEntity> entites)
			=> entites.ForEach(TakeProducts, @if: IsEnoughOnWarehouse);

		private bool IsEnoughOnWarehouse(GameEntity factory)
		{
			var groups = GetGroups(factory);
			var requiredProducts = RequiredProducts(groups);

			return groups.All((p) => AvailableProducts[p.Key] >= requiredProducts[p.Key]);
		}

		private void TakeProducts(GameEntity factory)
			=> RequiredProducts(factory).ForEach((p) => CreateRequest(p, factory));

		private static Dictionary<Product, int> RequiredProducts(GameEntity factory)
			=> RequiredProducts(GetGroups(factory));

		private static Dictionary<Product, int> RequiredProducts(IGrouping<Product, Product>[] groups)
			=> groups.ToDictionary(x => x.Key, x => x.Count());

		private void CreateRequest(KeyValuePair<Product, int> product, GameEntity factory)
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddRequireProduct(product.Key))
			         .Do((e) => e.AddPosition(factory.position))
			         .Do((e) => e.AddCount(product.Value))
			         .AttachTo(factory)
				;

			_contexts.game.GetInventoryItems()
			         .Single((p) => p.product.Value == product.Key)
			         .DecreaseInventoryItemCount(product.Value);
		}

		private static IGrouping<Product, Product>[] GetGroups(GameEntity entity)
		{
			var groups = entity.factory.Value.InputProducts.GroupBy((x) => x);
			return groups as IGrouping<Product, Product>[] ?? groups.ToArray();
		}
	}
}
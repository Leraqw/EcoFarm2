using System;
using System.Collections.Generic;
using System.Linq;
using Code.ECS.Components.ComplexComponentTypes;
using EcoFarmDataModule;

namespace Code.Utils.Extensions.Entitas
{
	public static class InventoryExtensions
	{
		public static void SetActualDebugName(this GameEntity @this)
			=> @this.ReplaceDebugName(@this.inventoryItem.Value);

		private static void ReplaceDebugName(this GameEntity @this, Item item)
			=> @this.ReplaceDebugName($"Item: {item.Name} ({item.Count})");

		public static GameEntity CreateInventoryItem(this GameContext @this, Product product)
			=> @this.CreateEntity()
			        .Do((e) => e.AddInventoryItem(new Item(product.Title)))
			        .Do((e) => e.SetActualDebugName())
			        .Do((e) => e.AddProduct(product))
			        .AttachTo(@this.inventoryEntity);

		public static IEnumerable<GameEntity> GetInventoryItems(this GameContext @this)
			=> @this.inventoryEntity.GetAttachedEntities()
			        .Where((e) => e.hasInventoryItem);
		
		public static GameEntity GetInventoryItem(this GameContext @this, Product product)
			=> @this.GetInventoryItems().Single((e) => e.product.Value == product);

		public static void IncreaseInventoryItemCount(this GameEntity @this, int count)
			=> @this.UpdateInventoryItemCount(with: (c) => c + count);

		public static void DecreaseInventoryItemCount(this GameEntity @this, int count)
			=> @this.UpdateInventoryItemCount(with: (c) => c - count);

		public static void UpdateInventoryItemCount(this GameEntity @this, int count)
			=> @this.UpdateInventoryItemCount(with: (_) => count);

		public static void UpdateInventoryItemCount(this GameEntity @this, Func<int, int> with)
			=> @this.Do((x) => x.inventoryItem.Value.Count = with(x.inventoryItem.Value.Count))
			        .Do((x) => x.ReplaceInventoryItem(x.inventoryItem.Value))
			        .Do((e) => e.SetActualDebugName());

		public static void IncreaseCoinsCount(this GameEntity @this, int value)
			=> @this.ReplaceCoinsCount(@this.coinsCount + value);

		public static void DecreaseCoinsCount(this GameEntity @this, int value)
			=> @this.ReplaceCoinsCount(@this.coinsCount - value);

		public static bool HasSameProduct(this GameEntity @this, GameEntity other)
			=> @this.product.Value == other.product.Value;
	}
}
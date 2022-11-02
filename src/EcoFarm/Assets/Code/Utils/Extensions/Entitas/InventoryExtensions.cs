using System.Collections.Generic;
using Code.ECS.Components.ComplexComponentTypes;
using static Code.Utils.StaticClasses.Constants.Temp;

namespace Code.Utils.Extensions.Entitas
{
	public static class InventoryExtensions
	{
		public static void SetActualDebugName(this GameEntity @this) 
			=> @this.ReplaceDebugName(@this.inventoryItem.Value);

		private static void ReplaceDebugName(this GameEntity @this, Item item) 
			=> @this.ReplaceDebugName($"Item: {item.Name} ({item.Count})");

		public static void CreateInventoryItem(this GameContext @this, string name, int count)
			=> @this.CreateEntity()
			        .Do((e) => e.AddInventoryItem((name, count)))
			        .Do((e) => e.SetActualDebugName())
			        .Do((e) => e.AddFruitTypeId(AppleID))
			        .Do((e) => e.AddAttachedTo(@this.inventoryEntity.attachableIndex));
		
		public static IEnumerable<GameEntity> GetInventoryItems(this GameContext @this) 
			=> @this.GetEntitiesWithAttachedTo(@this.inventoryEntity.attachableIndex);
	}
}
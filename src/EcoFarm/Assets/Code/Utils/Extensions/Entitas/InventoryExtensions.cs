namespace Code.Utils.Extensions.Entitas
{
	public static class InventoryExtensions
	{
		public static void CreateInventoryItem(this GameContext @this, string name, int count)
			=> @this.CreateEntity()
			        .Do((e) => e.AddInventoryItem((name, count)))
			        .Do((e) => e.AddAttachedTo(@this.inventoryEntity.attachTarget));
	}
}
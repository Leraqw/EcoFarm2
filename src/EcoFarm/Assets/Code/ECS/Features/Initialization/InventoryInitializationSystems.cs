namespace EcoFarm
{
	public sealed class InventoryInitializationSystems : Feature
	{
		public InventoryInitializationSystems(Contexts contexts)
			: base(nameof(InventoryInitializationSystems))
		{
			Add(new CreateInventorySystem(contexts));
			Add(new CreateInventoryItemsSystem(contexts));
			Add(new MarkItemAsCoinsSystem(contexts));
			Add(new InitializeSellDealSystem(contexts));
		}
	}
}
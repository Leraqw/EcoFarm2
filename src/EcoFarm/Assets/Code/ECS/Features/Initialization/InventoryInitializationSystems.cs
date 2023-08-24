namespace EcoFarm
{
	public sealed class InventoryInitializationSystems : FeatureBase
	{
		public InventoryInitializationSystems(SystemsFactory factory)
			: base(nameof(InventoryInitializationSystems), factory)
		{
			Add<CreateInventorySystem>();
			Add<CreateInventoryItemsSystem>();
			Add<MarkItemAsCoinsSystem>();
			Add<InitializeSellDealSystem>();
		}
	}
}
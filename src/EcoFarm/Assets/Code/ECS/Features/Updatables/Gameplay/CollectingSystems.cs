namespace EcoFarm
{
	public sealed class CollectingSystems : FeatureBase
	{
		public CollectingSystems(SystemsFactory factory)
			: base(nameof(CollectingSystems), factory)
		{
			Add<PickedToWarehouseSystem>();
			Add<CollectedToInventorySystem>();
			Add<SyncItemValueWithDebugSystem>();
		}
	}
}
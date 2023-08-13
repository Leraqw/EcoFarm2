


namespace EcoFarm
{
	public sealed class CollectingSystems : Feature
	{
		public CollectingSystems(Contexts contexts)
			: base(nameof(CollectingSystems))
		{
			Add(new PickedToWarehouseSystem(contexts));
			Add(new CollectedToInventorySystem(contexts));
			Add(new SyncItemValueWithDebugSystem(contexts));
		}
	}
}
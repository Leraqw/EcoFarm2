using Code.ECS.Systems.Inventory;
using Code.ECS.Systems.Warehouse;

namespace Code.ECS.Features
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
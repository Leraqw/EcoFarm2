using Code.ECS.Systems.Input;
using Code.ECS.Systems.Inventory;

namespace Code.ECS.Features
{
	public sealed class CollectingSystems : Feature
	{
		public CollectingSystems(Contexts contexts)
			: base(nameof(CollectingSystems))
		{
			Add(new OnMouseClickSystem(contexts));
			Add(new CollectToWarehouseSystem(contexts));
			Add(new CollectedToInventorySystem(contexts));
			Add(new SyncItemValueWithDebugSystem(contexts));
		}
	}
}
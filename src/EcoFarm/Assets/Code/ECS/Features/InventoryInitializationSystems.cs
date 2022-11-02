using Code.ECS.Systems.Inventory;

namespace Code.ECS.Features
{
	public sealed class InventoryInitializationSystems : Feature
	{
		public InventoryInitializationSystems(Contexts contexts)
			: base(nameof(InventoryInitializationSystems))
		{
			Add(new CreateInventorySystem(contexts));
			Add(new CreateInventoryItemsSystem(contexts));
		}
	}
}
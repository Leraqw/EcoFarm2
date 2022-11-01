using Code.ECS.Systems.Product;
using Code.ECS.Systems.Tree;
using Code.ECS.Systems.Warehouse;

namespace Code.ECS.Features
{
	public sealed class InitializationSystems : Feature
	{
		public InitializationSystems(Contexts contexts)
			: base(nameof(InitializationSystems))
		{
			Add(new DataBaseLoadSystems(contexts));
			
			Add(new InventoryInitializationSystems(contexts));

			Add(new SpawnTreeSystem(contexts));
			Add(new SpawnFruitSystem(contexts));
			Add(new SpawnBedsPlugsSystem(contexts));
			Add(new SpawnWarehouseSystem(contexts));
		}
	}
}
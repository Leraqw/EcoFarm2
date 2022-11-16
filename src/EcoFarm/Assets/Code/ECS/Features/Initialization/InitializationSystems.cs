using Code.ECS.Systems.Buildings;
using Code.ECS.Systems.Data;
using Code.ECS.Systems.Goals;
using Code.ECS.Systems.Level;
using Code.ECS.Systems.Product;
using Code.ECS.Systems.Tree;
using Code.ECS.Systems.Warehouse;
using Code.ECS.Systems.Watering.Bucket;
using Code.ECS.Systems.Watering.Crane;
using Code.ECS.Systems.Watering.Tree;

namespace Code.ECS.Features.Initialization
{
	public sealed class InitializationSystems : Feature
	{
		public InitializationSystems(Contexts contexts)
			: base(nameof(InitializationSystems))
		{
			Add(new SpawnStorage(contexts));
			Add(new DataBaseLoadSystems(contexts));
			Add(new CreateGoalForLevelSystem(contexts));
			Add(new CreateLevelTimerSystem(contexts));
			
			Add(new InventoryInitializationSystems(contexts));

			Add(new SpawnTreeSystem(contexts));
			Add(new TreePostInitializationSystem(contexts));
			Add(new SpawnFruitSystem(contexts));
			Add(new SpawnBedsPlugsSystem(contexts));
			Add(new SpawnWarehouseSystem(contexts));
			Add(new SpawnBuildButtons(contexts));
			Add(new SpawnCraneSystem(contexts));
			Add(new SpawnBucketSystem(contexts));
		}
	}
}
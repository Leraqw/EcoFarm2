using Code.ECS.Systems.Warehouse;
using Code.ECS.Systems.Watering.Bucket;

namespace Code.Tests
{
	public class Create
	{
		public static PickedToWarehouseSystem PickedToWarehouseSystem(Contexts contexts) => new(contexts);

		public static SpawnBucketSystem SpawnBucketSystem(Contexts contexts) => new(contexts);
	}
}
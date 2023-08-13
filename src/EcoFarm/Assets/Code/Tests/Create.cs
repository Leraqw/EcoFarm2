namespace EcoFarm.Tests
{
	public class Create
	{
		public static PickedToWarehouseSystem PickedToWarehouseSystem(Contexts contexts) => new(contexts);

		public static SpawnBucketSystem SpawnBucketSystem(Contexts contexts) => new(contexts);
	}
}
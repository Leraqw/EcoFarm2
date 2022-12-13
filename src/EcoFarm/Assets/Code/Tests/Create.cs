using Code.ECS.Systems.Warehouse;

namespace Code.Tests
{
	public class Create
	{
		public static PickedToWarehouseSystem System(Contexts contexts)
		{
			return new PickedToWarehouseSystem(contexts);
		}
	}
}
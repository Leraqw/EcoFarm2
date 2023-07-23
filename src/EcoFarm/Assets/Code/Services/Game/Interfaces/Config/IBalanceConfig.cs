

namespace Code
{
	public interface IBalanceConfig
	{
		IWateringConfig Watering { get; }

		ITreeConfig Tree { get; }

		IBucketConfig Bucket { get; }

		IWarehouseConfig Warehouse { get; }

		IFruitConfig Fruit { get; }

		IResourceConfig Water { get; }

		IResourceConfig Energy { get; }
		
		IFactoryConfig Factory { get; }
	}
}
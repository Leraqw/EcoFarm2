

namespace Code
{
	public interface IBalanceConfig
	{
		IWateringConfig Watering { get; }

		ITreeConfig Tree { get; }

		IBucketConfig Bucket { get; }

		IWarehouseConfig Warehouse { get; }

		IFruitConfig Fruit { get; }

		IBalanceResourceConfig Water { get; }

		IBalanceResourceConfig Energy { get; }
		
		IFactoryConfig Factory { get; }
	}
}
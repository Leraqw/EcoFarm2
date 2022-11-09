using Code.Services.Interfaces.Config.BalanceConfigs;

namespace Code.Services.Interfaces.Config
{
	public interface IBalanceConfig
	{
		IWateringConfig Watering { get; }

		ITreeConfig Tree { get; }

		IBucketConfig Bucket { get; }

		IWarehouseConfig Warehouse { get; }
		
		IFruitConfig Fruit { get; }
		IDealConfig       Deal  { get; }
	}

	public interface IDealConfig
	{
		int SellPrice { get; }
	}
}
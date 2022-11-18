using Code.Services.Game.Interfaces.Config.BalanceConfigs;

namespace Code.Services.Game.Interfaces.Config
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
	}
}
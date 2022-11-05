using Code.Services.Interfaces.Config.BalanceConfigs;

namespace Code.Services.Interfaces.Config
{
	public interface IBalanceConfig
	{
		IWateringConfig Watering { get; }
		
		ITreeConfig Tree { get; }
	}
}
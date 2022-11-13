using Code.Services.Game.Interfaces.Config.ResourcesConfigs;

namespace Code.Services.Game.Interfaces.Config
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }
		
		ICommonConfig Common { get; }
		
		IResourceConfig Resource { get; }
	}
}
using Code.Services.Interfaces.Config.ResourcesConfigs;

namespace Code.Services.Interfaces.Config
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }
		
		ICommonConfig Common { get; }
		
		IResourceConfig Resource { get; }
	}
}
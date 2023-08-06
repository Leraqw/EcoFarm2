namespace EcoFarm
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }

		ICommonConfig Common { get; }

		IResourceConfig Resource { get; }
	}
}
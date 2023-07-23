namespace Code
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }

		ICommonConfig Common { get; }

		IResourceConfig Resource { get; }
	}
}
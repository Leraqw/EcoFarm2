namespace Code.Services.Interfaces.Config
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }
		
		ICommonConfig Common { get; }
	}
}
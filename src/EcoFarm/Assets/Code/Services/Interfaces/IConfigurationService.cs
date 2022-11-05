namespace Code.Services.Interfaces
{
	public interface IConfigurationService
	{
		IBalanceConfig Balance { get; }
		
		public interface IBalanceConfig
		{
			float DroughtDuration { get; }
		}
	}
}
namespace Code.Services.Interfaces.Config.BalanceConfigs
{
	public interface IWateringConfig
	{
		float DroughtDuration { get; }
		int   DroughtStep     { get; }
		int   WateringStep    { get; }
	}
}
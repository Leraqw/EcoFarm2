namespace Code.Services.Game.Interfaces.Config.BalanceConfigs
{
	public interface IWateringConfig
	{
		float DroughtDuration { get; }
		int   DroughtStep     { get; }
		int   WateringStep    { get; }
	}
}
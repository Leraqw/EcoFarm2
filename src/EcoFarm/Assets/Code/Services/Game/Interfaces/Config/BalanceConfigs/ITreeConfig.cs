namespace Code.Services.Game.Interfaces.Config.BalanceConfigs
{
	public interface ITreeConfig
	{
		int MinWatering { get; }
		int MaxWatering { get; }
		int InitialWatering { get; }
	}
}
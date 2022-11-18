namespace Code.Services.Game.Interfaces.Config.BalanceConfigs
{
	public interface IResourceConfig
	{
		int MaxValue   { get; }
		int StartValue { get; }
		int RenewPrice { get; }
	}
}
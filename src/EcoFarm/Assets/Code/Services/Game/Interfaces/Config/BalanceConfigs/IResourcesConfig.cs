namespace Code
{
	public interface IBalanceResourceConfig
	{
		int MaxValue   { get; }
		int StartValue { get; }
		int RenewPrice { get; }
	}
}
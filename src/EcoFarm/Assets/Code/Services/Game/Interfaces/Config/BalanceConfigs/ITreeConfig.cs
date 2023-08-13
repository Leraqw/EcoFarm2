namespace EcoFarm
{
	public interface ITreeConfig
	{
		int MinWatering { get; }
		int MaxWatering { get; }
		int InitialWatering { get; }
	}
}
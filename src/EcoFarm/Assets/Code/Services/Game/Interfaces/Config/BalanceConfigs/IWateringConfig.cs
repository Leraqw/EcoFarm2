namespace EcoFarm
{
	public interface IWateringConfig
	{
		float DroughtDuration { get; }
		int   DroughtStep     { get; }
		int   WateringStep    { get; }
	}
}
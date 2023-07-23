namespace Code
{
	public interface IFactoryConfig
	{
		float WorkingDuration           { get; }
		float SendProductToFactoryDelay { get; }
		float RoadToFactoryDuration     { get; }
	}
}
namespace EcoFarm
{
	public sealed class LevelChoiceSystems : FeatureBase
	{
		public LevelChoiceSystems(SystemsFactory factory)
			: base(nameof(LevelChoiceSystems), factory)
		{
			Add<TearDownLevelsSystems>();
		}
	}
}
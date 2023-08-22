namespace EcoFarm
{
	public sealed class DurationSystems : FeatureBase
	{
		public DurationSystems(SystemsFactory factory)
			: base(nameof(DurationSystems), factory)
		{
			Add<DurationSystem>();
			Add<CheckDurationUpSystem>();
		}
	}
}
namespace EcoFarm
{
	public sealed class GrowingSystems : FeatureBase
	{
		public GrowingSystems(SystemsFactory factory)
			: base(nameof(GrowingSystems), factory)
		{
			Add<WaitBeforeGrowingSystem>();
			Add<GrowingSystem>();
			Add<WaitAfterGrowingSystem>();
			Add<CheckGrowthUpSystem>();
		}
	}
}
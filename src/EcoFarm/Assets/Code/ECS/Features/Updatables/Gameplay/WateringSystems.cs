namespace EcoFarm
{
	public sealed class WateringSystems : FeatureBase
	{
		public WateringSystems(SystemsFactory factory)
			: base(nameof(WateringSystems), factory)
		{
			Add<PourWaterSystem>();

			Add<TreeHighlightSystem>();

			Add<WaterNearTreeSystem>();
			Add<OnTreeWateredSystem>();
			Add<CheckTreeUnderWateringSystem>();
			Add<CheckTreeOverWateringSystem>();
			Add<FillBucketSystem>();

			Add<SpawnDroughtTimerSystem>();
			Add<DroughtTreeSystem>();
			Add<ResetDroughtTimerSystem>();
			Add<SyncSpriteWithBucketStateSystem>();
		}
	}
}
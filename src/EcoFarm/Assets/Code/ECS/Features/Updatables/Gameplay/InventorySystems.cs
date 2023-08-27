namespace EcoFarm
{
	public sealed class InventorySystems : FeatureBase
	{
		public InventorySystems(SystemsFactory factory)
			: base(nameof(InventorySystems), factory)
		{
			Add<MakeSellDealSystem>();
			Add<SyncCoinItemCountSystem>();
			Add<SubtractSoldApplesSystem>();
			Add<DeactivateDealSystem>();
			Add<ActualizeCountToSellSliderMaxValueSystem>();

			// TODO: GoalsSystems
			Add<CheckGoalsByProductSystem>();
			Add<UpdateProductGoalsProgressSystem>();
		}
	}
}
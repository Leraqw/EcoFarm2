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

			// TODO: GoalsSystems
			Add<CheckGoalsByProductSystem>();
			Add<UpdateProductGoalsProgressSystem>();
		}
	}
}
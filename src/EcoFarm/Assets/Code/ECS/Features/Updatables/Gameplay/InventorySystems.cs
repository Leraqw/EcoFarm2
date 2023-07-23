



namespace Code
{
	public sealed class InventorySystems : Feature
	{
		public InventorySystems(Contexts contexts)
			: base(nameof(InventorySystems))
		{
			Add(new MakeSellDealSystem(contexts));
			Add(new SyncCoinItemCountSystem(contexts));
			Add(new SubtractSoldApplesSystem(contexts));
			Add(new DeactivateDealSystem(contexts));
			Add(new ActualizeCountToSellSliderMaxValueSystem(contexts));
			
			// TODO: GoalsSystems
			Add(new CheckGoalsByProductSystem(contexts));
			Add(new UpdateProductGoalsProgressSystem(contexts));
		}
	}
}
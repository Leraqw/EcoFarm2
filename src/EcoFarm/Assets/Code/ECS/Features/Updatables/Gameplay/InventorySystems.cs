using Code.ECS.Systems.Goals;
using Code.ECS.Systems.Inventory.SellDeal;
using Code.ECS.Systems.UI;

namespace Code.ECS.Features.Updatables.Gameplay
{
	public sealed class InventorySystems : Feature
	{
		public InventorySystems(Contexts contexts)
			: base(nameof(InventorySystems))
		{
			Add(new MakeSellDealSystem(contexts));
			Add(new SubtractSoldApplesSystem(contexts));
			Add(new DeactivateDealSystem(contexts));
			Add(new ActualizeCountToSellSliderMaxValueSystem(contexts));
			
			// TODO: GoalsSystems
			Add(new CheckGoalsByProductSystem(contexts));
		}
	}
}
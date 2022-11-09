using Code.ECS.Systems.Inventory.SellDeal;

namespace Code.ECS.Features
{
	public sealed class InventorySystems : Feature
	{
		public InventorySystems(Contexts contexts)
			: base(nameof(InventorySystems))
		{
			Add(new SubtractSoldApplesSystem(contexts));
			Add(new MakeSellDealSystem(contexts));
			Add(new DeactivateDealSystem(contexts));
		}
	}
}
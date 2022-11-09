using Code.ECS.Systems.Inventory.SellDeal;

namespace Code.ECS.Features
{
	public sealed class InventorySystems : Feature
	{
		public InventorySystems(Contexts contexts)
			: base(nameof(InventorySystems))
		{
			Add(new MakeSellDealSystem(contexts));
		}
	}
}
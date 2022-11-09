using Code.Utils.Extensions;
using Entitas;
using static Code.Utils.StaticClasses.Constants.Temp;

namespace Code.ECS.Systems.Inventory
{
	public sealed class InitializeSellDealSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellDealSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Sell Deal"))
			            .Do((e) => e.isSellDeal = true)
			            .Do((e) => e.AddFruitTypeId(AppleID))
			            .Do((e) => e.AddCount(0));
	}
}
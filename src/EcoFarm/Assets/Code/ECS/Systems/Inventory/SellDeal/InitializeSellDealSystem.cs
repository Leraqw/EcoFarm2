using System.Linq;

using Entitas;

namespace Code
{
	public sealed class InitializeSellDealSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellDealSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Sell Deal"))
			            .Do((e) => e.isSellDeal = true)
			            .Do((e) => e.AddProduct(_contexts.game.storage.Value.Trees.First().Product));
	}
}
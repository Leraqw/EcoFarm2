using System.Linq;
using System.Runtime.InteropServices;
using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class InitializeSellDealSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public InitializeSellDealSystem(Contexts contexts, GameEntity.Factory gameEntityFactory)
		{
			_contexts = contexts;
			_gameEntityFactory = gameEntityFactory;
		}

		private Tree FirstTree => _contexts.game.storage.Value.Trees.First();

		public void Initialize()
			=> _gameEntityFactory.Create()
			                     .Do((e) => e.AddDebugName("Sell Deal"))
			                     .Do((e) => e.isSellDeal = true)
			                     .Do((e) => e.AddProduct(FirstTree.Product));
	}
}
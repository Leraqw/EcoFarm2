using System.Linq;
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

        public void Initialize()
            => _gameEntityFactory.Create()
                .Do((e) => e.AddDebugName("Sell Deal"))
                .Do((e) => e.isSellDeal = true)
                .Do((e) => e.AddProduct(_contexts.game.storage.Value.Trees.First().Product));
    }
}
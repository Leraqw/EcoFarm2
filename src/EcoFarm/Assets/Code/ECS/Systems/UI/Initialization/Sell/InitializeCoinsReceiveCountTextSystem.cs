using Entitas;
using Zenject;
using static GameMatcher;

namespace EcoFarm
{
    public sealed class InitializeCoinsReceiveCountTextSystem : IInitializeSystem, IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IUiService _uiService;
        private readonly GameEntity.Factory _gameEntityFactory;
        private GameEntity _entity;

        [Inject]
        public InitializeCoinsReceiveCountTextSystem
        (
            Contexts contexts,
            IUiService uiService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _contexts = contexts;
            _uiService = uiService;
            _gameEntityFactory = gameEntityFactory;
        }

        public void Initialize()
        {
            _entity = _gameEntityFactory.Create();
            _entity.AddDebugName("Coins Receive Count");
            _entity.AddView(_uiService.Windows.Sell.CoinsReceiveCount.gameObject);
            _entity.AddText(0.ToString());
        }

        public void Execute() => _entity.ReplaceSellCoefficient(_contexts.game.sellDealEntity.product.Value.Price);
    }
}
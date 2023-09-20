using Entitas;
using Zenject;

namespace EcoFarm
{
    public sealed class InitializeCurrentCountTextSystem : IInitializeSystem
    {
        private readonly IUiService _uiService;
        private readonly GameEntity.Factory _gameEntityFactory;

        [Inject]
        public InitializeCurrentCountTextSystem
        (
            Contexts contexts,
            IUiService uiService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _uiService = uiService;
            _gameEntityFactory = gameEntityFactory;
        }

        public void Initialize()
            => _gameEntityFactory.Create()
                .Do((e) => e.AddDebugName("Products Count"))
                .Do((e) => e.AddView(_uiService.Windows.Sell.ProductsCount.gameObject))
                .Do((e) => e.AddText(0.ToString()))
                .Do((e) => e.AddSellCoefficient(1));
    }
}
using System.Linq;
using Entitas;
using Zenject;

namespace EcoFarm
{
    public sealed class InitializeCountToSellSliderSystem : IInitializeSystem, IExecuteSystem
    {
        private readonly Contexts _contexts;
        private readonly IUiService _uiService;
        private readonly GameEntity.Factory _gameEntityFactory;
        private GameEntity _entity;
        private GameEntity[] _inventoryItems;

        [Inject]
        public InitializeCountToSellSliderSystem
        (
            Contexts contexts,
            IUiService uiService,
            GameEntity.Factory gameEntityFactory
        )
        {
            _uiService = uiService;
            _contexts = contexts;
            _gameEntityFactory = gameEntityFactory;
        }

        private GameEntity SellWindow => _contexts.game.GetEntities(GameMatcher.SellWindow).First();

        public void Initialize()
        {
            _entity = _gameEntityFactory.Create();
            _entity.AddDebugName("Slider");
            _entity.AttachTo(SellWindow);
            _entity.AddView(_uiService.Windows.Sell.CountToSellSlider.gameObject);
            _entity.AddSliderValue(0);
        }

        public void Execute()
        {
            _entity.ReplaceProduct(_contexts.game.sellDealEntity.product.Value);

            _inventoryItems = _contexts.game.GetEntities(GameMatcher.InventoryItem);
            _inventoryItems.ForEach(ActualizeSliders);
        }

        private void ActualizeSliders(GameEntity item)
        {
            if (_entity.HasSameProduct(item)) 
                _entity.ReplaceSliderMaxValue(item.inventoryItem.Value.Count);
        }
    }
}
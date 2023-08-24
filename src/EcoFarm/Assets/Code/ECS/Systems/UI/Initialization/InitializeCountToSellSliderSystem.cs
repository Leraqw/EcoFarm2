using System.Linq;



using Entitas;

namespace EcoFarm
{
	public sealed class InitializeCountToSellSliderSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializeCountToSellSliderSystem(Contexts contexts, IUiService uiService)
		{
			_uiService = uiService;
			_contexts = contexts;
		}

		private GameEntity SellWindow => _contexts.game.GetEntities(GameMatcher.SellWindow).First();

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Slider"))
			            .Do((e) => e.AddView(_uiService.Windows.Sell.CountToSellSlider.gameObject))
			            .AttachTo(SellWindow)
			            .Do((e) => e.AddProduct(_contexts.game.storage.Value.Trees.First().Product))
			            .Do((e) => e.AddSliderValue(0))
			            .Do((e) => e.AddSliderMaxValue(0));
	}
}
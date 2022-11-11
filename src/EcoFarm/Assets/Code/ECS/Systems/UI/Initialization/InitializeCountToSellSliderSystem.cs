using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.UI.Initialization
{
	public sealed class InitializeCountToSellSliderSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCountToSellSliderSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		private GameEntity SellWindow => _contexts.game.GetEntities(GameMatcher.SellWindow).First();

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Slider"))
			            .Do((e) => e.AddView(UI.Windows.Sell.CountToSellSlider.gameObject))
			            .Do((e) => e.AddAttachedTo(SellWindow.attachableIndex))
			            .Do((e) => e.AddProduct(_contexts.services.dataService.Value.AppleTree.Product))
			            .Do((e) => e.AddSliderValue(0))
			            .Do((e) => e.AddSliderMaxValue(0));
	}
}
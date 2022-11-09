using System.Linq;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Code.Utils.StaticClasses;
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
			            .Do((e) => e.AddView(UI.WindowSell.CountToSellSlider.gameObject))
			            .Do((e) => e.AddAttachedTo(SellWindow.attachableIndex))
			            .Do((e) => e.AddFruitTypeId(Constants.Temp.AppleID))
			            .Do((e) => e.AddSliderValue(0))
			            .Do((e) => e.AddSliderMaxValue(0));
	}
}
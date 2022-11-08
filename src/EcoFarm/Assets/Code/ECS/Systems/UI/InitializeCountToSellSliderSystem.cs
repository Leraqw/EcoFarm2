using System.Linq;
using Code.ECS.Components.ComplexComponentTypes;
using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.UI
{
	public sealed class InitializeCountToSellSliderSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCountToSellSliderSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		private Item FirstInventoryItem => _contexts.game.GetInventoryItems().First().inventoryItem.Value;

		public void Initialize()
		{
			_contexts.game.CreateEntity()
			         .Do((e) => e.AddDebugName("Slider"))
			         .Do((e) => e.AddView(UI.WindowSell.CountToSellSlider.gameObject))
			         .Do((e) => e.AddSliderValue(0))
			         .Do((e) => e.AddSliderMaxValue(0))
				;
		}
	}
}
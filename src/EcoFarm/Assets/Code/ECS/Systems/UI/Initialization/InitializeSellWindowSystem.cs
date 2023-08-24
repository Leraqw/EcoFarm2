


using Entitas;

namespace EcoFarm
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializeSellWindowSystem(Contexts contexts, IUiService uiService)
		{
			_uiService = uiService;
			_contexts = contexts;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("SellWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(_uiService.Windows.Sell.gameObject))
			            .Do((e) => e.AddSellWindow(_uiService.Windows.Sell))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isRequirePreparation = true);
	}
}
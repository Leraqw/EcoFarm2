


using Entitas;

namespace Code
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeSellWindowSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("SellWindow"))
			            .Do((e) => e.AddActivate(false))
			            .Do((e) => e.AddView(UI.Windows.Sell.gameObject))
			            .Do((e) => e.AddSellWindow(UI.Windows.Sell))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isRequirePreparation = true);
	}
}
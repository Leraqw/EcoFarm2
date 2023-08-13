

using Entitas;

namespace EcoFarm
{
	public sealed class InitializeCurrentCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public InitializeCurrentCountTextSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UI => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Products Count"))
			            .Do((e) => e.AddView(UI.Windows.Sell.ProductsCount.gameObject))
			            .Do((e) => e.AddText(0.ToString()))
			            .Do((e) => e.AddSellCoefficient(1));
	}
}
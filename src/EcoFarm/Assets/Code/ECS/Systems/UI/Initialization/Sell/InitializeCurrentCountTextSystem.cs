using Entitas;

namespace EcoFarm
{
	public sealed class InitializeCurrentCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializeCurrentCountTextSystem(Contexts contexts, IUiService uiService)
		{
			_uiService = uiService;
			_contexts = contexts;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Products Count"))
			            .Do((e) => e.AddView(_uiService.Windows.Sell.ProductsCount.gameObject))
			            .Do((e) => e.AddText(0.ToString()))
			            .Do((e) => e.AddSellCoefficient(1));
	}
}
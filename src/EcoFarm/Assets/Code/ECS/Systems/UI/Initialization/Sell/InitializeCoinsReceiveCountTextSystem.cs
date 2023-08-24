using Entitas;

namespace EcoFarm
{
	public sealed class InitializeCoinsReceiveCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public InitializeCoinsReceiveCountTextSystem(Contexts contexts, IUiService uiService)
		{
			_contexts = contexts;
			_uiService = uiService;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Coins Receive Count"))
			            .Do((e) => e.AddView(_uiService.Windows.Sell.CoinsReceiveCount.gameObject))
			            .Do((e) => e.AddText(0.ToString()))
			            .Do((e) => e.AddSellCoefficient(_contexts.game.sellDealEntity.product.Value.Price));
	}
}
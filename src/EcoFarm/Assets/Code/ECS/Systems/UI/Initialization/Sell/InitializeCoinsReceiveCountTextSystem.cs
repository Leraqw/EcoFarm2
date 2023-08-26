using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class InitializeCoinsReceiveCountTextSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public InitializeCoinsReceiveCountTextSystem
		(
			Contexts contexts,
			IUiService uiService,
			GameEntity.Factory gameEntityFactory
		)
		{
			_contexts = contexts;
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
			=> _gameEntityFactory.Create()
			            .Do((e) => e.AddDebugName("Coins Receive Count"))
			            .Do((e) => e.AddView(_uiService.Windows.Sell.CoinsReceiveCount.gameObject))
			            .Do((e) => e.AddText(0.ToString()))
			            .Do((e) => e.AddSellCoefficient(_contexts.game.sellDealEntity.product.Value.Price));
	}
}
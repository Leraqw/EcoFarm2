using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class InitializeSellWindowSystem : IInitializeSystem
	{
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		[Inject]
		public InitializeSellWindowSystem(IUiService uiService, GameEntity.Factory gameEntityFactory)
		{
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
			=> _gameEntityFactory.Create()
			                     .Do((e) => e.AddDebugName("SellWindow"))
			                     .Do((e) => e.AddActivate(false))
			                     .Do((e) => e.AddView(_uiService.Windows.Sell.gameObject))
			                     .Do((e) => e.AddSellWindow(_uiService.Windows.Sell))
			                     .Do((e) => e.MakeAttachable())
			                     .Do((e) => e.isRequirePreparation = true);
	}
}
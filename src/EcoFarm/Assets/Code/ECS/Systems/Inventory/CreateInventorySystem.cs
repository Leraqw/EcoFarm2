using Entitas;

namespace EcoFarm
{
	public sealed class CreateInventorySystem : IInitializeSystem
	{
		private readonly IUiService _uiService;
		private readonly GameEntity.Factory _gameEntityFactory;

		public CreateInventorySystem(IUiService uiService, GameEntity.Factory gameEntityFactory)
		{
			_uiService = uiService;
			_gameEntityFactory = gameEntityFactory;
		}

		public void Initialize()
			=> _gameEntityFactory.Create()
			            .Do((e) => e.AddDebugName("Inventory"))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isInventory = true)
			            .Do((e) => e.AddCoinsCount(0))
			            .Do((e) => e.AddView(_uiService.CoinsView));
	}
}
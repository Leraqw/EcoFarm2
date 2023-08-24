using Entitas;

namespace EcoFarm
{
	public sealed class CreateInventorySystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public CreateInventorySystem(Contexts contexts, IUiService uiService)
		{
			_uiService = uiService;
			_contexts = contexts;
		}

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Inventory"))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isInventory = true)
			            .Do((e) => e.AddCoinsCount(0))
			            .Do((e) => e.AddView(_uiService.CoinsView));
	}
}
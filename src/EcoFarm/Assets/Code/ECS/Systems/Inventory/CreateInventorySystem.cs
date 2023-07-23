


using Entitas;

namespace Code
{
	public sealed class CreateInventorySystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventorySystem(Contexts contexts) => _contexts = contexts;

		private IUiService UIService => _contexts.services.uiService.Value;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Inventory"))
			            .Do((e) => e.MakeAttachable())
			            .Do((e) => e.isInventory = true)
			            .Do((e) => e.AddCoinsCount(0))
			            .Do((e) => e.AddView(UIService.CoinsView));
	}
}
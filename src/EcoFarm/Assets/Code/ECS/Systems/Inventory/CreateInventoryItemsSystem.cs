


using EcoFarmModel;
using Entitas;

namespace Code
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventoryItemsSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UIService => _contexts.services.uiService.Value;

		private Storage Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Products.ForEach(Create);

		private void Create(Product product)
			=> _contexts.game.CreateInventoryItem(product)
			            .Do((e) => e.AddView(UIService.AppleView));
	}
}
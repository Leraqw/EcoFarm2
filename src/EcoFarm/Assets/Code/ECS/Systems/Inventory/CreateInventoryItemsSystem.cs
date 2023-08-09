using Entitas;

namespace EcoFarm
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventoryItemsSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UIService => _contexts.services.uiService.Value;

		private StorageSO Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Products.ForEach(Create);

		private void Create(ProductSO product)
			=> _contexts.game.CreateInventoryItem(product)
			            .Do((e) => e.AddView(UIService.AppleView));
	}
}
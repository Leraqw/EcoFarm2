using Entitas;

namespace EcoFarm
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;
		private readonly IUiService _uiService;

		public CreateInventoryItemsSystem(Contexts contexts, IUiService uiService)
		{
			_uiService = uiService;
			_contexts = contexts;
		}

		private Storage Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Products.ForEach(Create);

		private void Create(Product product)
			=> _contexts.game.CreateInventoryItem(product)
			            .Do((e) => e.AddView(_uiService.AppleView));
	}
}
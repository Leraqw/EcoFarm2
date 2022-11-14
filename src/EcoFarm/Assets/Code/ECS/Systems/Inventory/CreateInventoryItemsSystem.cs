using Code.Services.Game.Interfaces.Ui;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using EcoFarmDataModule;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventoryItemsSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UIService => _contexts.services.uiService.Value;

		private Storage Storage => _contexts.game.storage.Value;

		public void Initialize() => Storage.Products.ForEach(Create);

		private void Create(EcoFarmDataModule.Product product)
			=> _contexts.game.CreateInventoryItem(product)
			            .Do((e) => e.AddView(UIService.AppleView));
	}
}
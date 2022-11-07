using Code.Services.Interfaces;
using Code.Utils.Extensions;
using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventoryItemsSystem(Contexts contexts) => _contexts = contexts;

		private IUiService UIService => _contexts.services.uiService.Value;

		public void Initialize() => _contexts.game.CreateInventoryItem("Apple", 0)
		                                     .Do((e) => e.AddView(UIService.AppleView));
	}
}
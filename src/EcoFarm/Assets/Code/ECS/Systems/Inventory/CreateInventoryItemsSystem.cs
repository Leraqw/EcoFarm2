using Code.Utils.Extensions.Entitas;
using Entitas;

namespace Code.ECS.Systems.Inventory
{
	public sealed class CreateInventoryItemsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public CreateInventoryItemsSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize() => _contexts.game.CreateInventoryItem("Apple", 0);
	}
}
using Entitas;

namespace EcoFarm
{
	public sealed class SpawnStorageSystem : IInitializeSystem
	{
		private readonly GameContext _context;

		public SpawnStorageSystem(Contexts contexts) => _context = contexts.game;

		public void Initialize()
		{
			_context.ReplaceStorage(ServicesMediator.DataProvider.Storage);
			_context.storageEntity.ReplaceDebugName(nameof(Storage));
		}
	}
}
using Entitas;

namespace EcoFarm
{
	public sealed class SpawnStorage : IInitializeSystem
	{
		private readonly GameContext _context;

		public SpawnStorage(Contexts contexts) => _context = contexts.game;

		public void Initialize()
		{
			_context.ReplaceStorage(ServicesMediator.DataProvider.Storage);
			_context.storageEntity.ReplaceDebugName(nameof(Storage));
		}
	}
}
using Entitas;
using Zenject;

namespace EcoFarm
{
	public sealed class SpawnStorageSystem : IInitializeSystem
	{
		private readonly GameContext _context;
		private readonly IDataProviderService _dataProvider;

		[Inject]
		public SpawnStorageSystem(Contexts contexts, IDataProviderService dataProvider)
		{
			_dataProvider = dataProvider;
			_context = contexts.game;
		}

		public void Initialize()
		{
			_context.ReplaceStorage(_dataProvider.Storage);
			_context.storageEntity.ReplaceDebugName(nameof(Storage));
		}
	}
}
using Code.Utils.Extensions;
using EcoFarmModel;
using Entitas;

namespace Code.ECS.Systems.Data
{
	public sealed class SpawnStorage : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnStorage(Contexts contexts) => _contexts = contexts;

		private Storage Storage => _contexts.services.dataService.Value.Storage;

		public void Initialize()
			=> _contexts.game.Do((c) => c.ReplaceStorage(Storage))
			            .storageEntity.Do((e) => e.ReplaceDebugName(nameof(Storage)));
	}
}
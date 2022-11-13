using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Data
{
	public sealed class SpawnStorage : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnStorage(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game
			            .SetStorage(_contexts.services.dataService.Value.Storage)
			            .Do((e) => e.AddDebugName("Storage"));
	}
}
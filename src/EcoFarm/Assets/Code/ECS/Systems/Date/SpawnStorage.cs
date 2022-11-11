using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems.Date
{
	public sealed class SpawnStorage : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnStorage(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.AddDebugName("Storage"))
			            .Do((e) => e.AddStorage(_contexts.services.dataService.Value.Storage));
	}
}
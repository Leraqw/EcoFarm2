using Code.Utils.Extensions;
using Entitas;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreeSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
			=> _contexts.game.CreateEntity()
			            .Do((e) => e.isTree = true)
			            .AddRequireView("Trees/Prefabs/Tree");
	}
}
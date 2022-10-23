using Entitas;

namespace Code.ECS.Systems
{
	public sealed class SpawnTreeSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnTreeSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			var entity = _contexts.game.CreateEntity();
			entity.isTree = true;
			entity.AddRequireGameObject("Trees/Prefabs/Tree");
		}
	}
}
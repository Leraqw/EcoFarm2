using Entitas;

namespace Code.ECS.Systems
{
	public sealed class SpawnBedsPlugsSystem : IInitializeSystem
	{
		private readonly Contexts _contexts;

		public SpawnBedsPlugsSystem(Contexts contexts) => _contexts = contexts;

		public void Initialize()
		{
			var path = "Environment/Trees Beds/Prefabs/Tree Bed Plug";
		}
	}
}